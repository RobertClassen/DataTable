namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using DeepReflection.Editor;
	using MicroScopes;
	using MicroScopes.Editor;
	using UnityEditor;
	using UnityEngine;
	using VectorMath;

	[CustomPropertyDrawer(typeof(CustomCellDrawerAttribute), true)]
	[CustomPropertyDrawer(typeof(DataTable), true)]
	public class DataTableDrawer : PropertyDrawer
	{
		#region Constants
		private const string HeadersFieldName = "headers";
		private const string RowsFieldName = "rows";
		private const string CellsFieldName = "cells";
		private const string Null = null;

		private const int NameLineCount = 1;
		private const int HeaderLineCount = 1;
		private static readonly float SingleLineHeight = EditorGUIUtility.singleLineHeight;
		private static readonly float NameLineHeight = SingleLineHeight;
		private static readonly float HeaderLineHeight = SingleLineHeight;

		private static readonly HashSet<Type> InlineTypes = new HashSet<Type> { 
			typeof(List<Color>), 
			typeof(List<string>), 
			typeof(List<UnityEngine.Object>), 
		};
		#endregion

		#region Fields
		private Type type = null;
		private bool isInlineType = false;
		#endregion

		#region Methods
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			using(new PropertyScope(position, label, property))
			{
				GUI.Box(position, Null);

				DataTable dataTable = property.GetTargetObject() as DataTable;
				if(dataTable == null)
				{
					Debug.LogError("null");
				}

				SerializedProperty rows = property.FindPropertyRelative(RowsFieldName);
				int rowCount = rows.arraySize;
				int lineCount = property.isExpanded ? NameLineCount + HeaderLineCount + rowCount : NameLineCount;

				Rect titleRect = position.GetRow(0, lineCount, 0f);
				DrawTitle(titleRect, property, label, dataTable.Width, dataTable.Height);
				if(!property.isExpanded)
				{
					return;
				}

				lineCount = NameLineCount + HeaderLineCount + rowCount;

				Rect headerRect = position.GetRow(1, lineCount);
				SerializedProperty headers = property.FindPropertyRelative(HeadersFieldName);
				if(headers.arraySize != dataTable.Width)
				{
					headers.arraySize = dataTable.Width;
				}
				DrawHeaders(headerRect, headers);

				CustomCellDrawerAttribute customCellDrawer = attribute as CustomCellDrawerAttribute;
				Action<Rect, SerializedProperty, Action<int, int>, Vector2Int> drawCell = customCellDrawer != null 
					? customCellDrawer.DrawCell : (Action<Rect, SerializedProperty, Action<int, int>, Vector2Int>)DrawCell;
				for(int y = 0; y < rowCount; y++)
				{
					Rect rowRect = position.GetRow(y + NameLineCount + HeaderLineCount, lineCount);
					EditorGUI.LabelField(rowRect, y.ToString());
					DrawRow(rowRect.Indent(2), rows.GetArrayElementAtIndex(y), drawCell, dataTable, y);
				}
			}
		}

		private void DrawTitle(Rect rect, SerializedProperty property, GUIContent label, int width, int height)
		{
			Rect nameRect = rect.Expand(0f, -10f, 0f, 0f);
			//EditorGUI.DrawRect(nameRect, Color.yellow);
			label.text = string.Format("{0} ({1}x{2})", label.text, width, height);
			bool isExpanded = EditorGUI.Foldout(nameRect, property.isExpanded, label, true);
			if(isExpanded != property.isExpanded)
			{
				property.isExpanded = isExpanded;
			}
		}

		private void DrawHeaders(Rect rect, SerializedProperty headers)
		{
			EditorGUI.DrawRect(rect, Color.grey);
			using(new GUIColorScope(GUI.color * (EditorGUIUtility.isProSkin ? 1.75f : 0.75f)))
			{
				rect = rect.Indent(2);
				int width = headers.arraySize;
				for(int x = 0; x < width; x++)
				{
					//EditorGUI.LabelField(rect.GetColumn(x, width), x.ToString());
					EditorGUI.PropertyField(rect.GetColumn(x, width), headers.GetArrayElementAtIndex(x), GUIContent.none);
				}
			}
		}

		private void DrawRow(Rect rect, SerializedProperty row, 
			Action<Rect, SerializedProperty, Action<int, int>, Vector2Int> drawCell, DataTable dataTable, int y)
		{
			SerializedProperty cells = row.FindPropertyRelative(CellsFieldName);
			if(cells == null)
			{
				EditorGUI.LabelField(rect, "Could not find cells");
				return;
			}

			int xMax = cells.arraySize;
			if(type == null)
			{
				type = cells.GetArrayElementAtIndex(0).GetFullType();
				isInlineType = InlineTypes.Contains(type);
			}

			for(int x = 0; x < xMax; x++)
			{
				drawCell(rect.GetColumn(x, xMax), cells.GetArrayElementAtIndex(x), dataTable.NotifyCellChangeListeners, new Vector2Int(x, y));
			}
		}

		private void DrawCell(Rect rect, SerializedProperty cell, Action<int, int> dataTable, Vector2Int coordinate)
		{
			if(!cell.hasChildren || isInlineType)
			{
				EditorGUI.PropertyField(rect, cell, GUIContent.none);
			}
			else
			{
				if(GUI.Button(rect, "Show"))
				{
					CellEditor.GetWindow(cell);
				}
			}
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			if(!property.isExpanded)
			{
				return NameLineHeight;
			}
			SerializedProperty rows = property.FindPropertyRelative(RowsFieldName);
			return NameLineHeight + HeaderLineHeight + rows.arraySize * SingleLineHeight;
		}
		#endregion
	}
}