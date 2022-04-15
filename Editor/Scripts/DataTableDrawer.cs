namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEditor;
	using DeepReflection.Editor;
	using UnityEngine;
	using VectorMath;

	[CustomPropertyDrawer(typeof(CustomCellDrawerAttribute), true)]
	[CustomPropertyDrawer(typeof(DataTable), true)]
	public class DataTableDrawer : PropertyDrawer
	{
		#region Constants
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
			using(new EditorGUI.PropertyScope(position, label, property))
			{
				GUI.Box(position, Null);

				DataTable dataTable = property.GetTargetObject() as DataTable;
				if(dataTable == null)
				{
					Debug.LogError("null");
				}

				SerializedProperty rows = property.FindPropertyRelative(RowsFieldName);
				int yMax = rows.arraySize;
				int lineCount = yMax + NameLineCount + HeaderLineCount;

				Rect nameRect = position.GetRow(0, lineCount);
				EditorGUI.LabelField(nameRect, label);

				Rect headerRect = position.GetRow(1, lineCount);
				DrawHeaders(headerRect.Indent(2), dataTable.Width);

				CustomCellDrawerAttribute customCellDrawer = attribute as CustomCellDrawerAttribute;
				Action<Rect, SerializedProperty, Action<int, int>, Vector2Int> drawCell = customCellDrawer != null 
					? customCellDrawer.DrawCell : (Action<Rect, SerializedProperty, Action<int, int>, Vector2Int>)DrawCell;
				for(int y = 0; y < yMax; y++)
				{
					Rect rowRect = position.GetRow(y + NameLineCount + HeaderLineCount, lineCount);
					EditorGUI.LabelField(rowRect, y.ToString());
					DrawRow(rowRect.Indent(2), rows.GetArrayElementAtIndex(y), drawCell, dataTable, y);
				}
			}
		}

		private void DrawHeaders(Rect rect, int width)
		{
			for(int x = 0; x < width; x++)
			{
				EditorGUI.LabelField(rect.GetColumn(x, width), x.ToString());
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
			SerializedProperty rows = property.FindPropertyRelative(RowsFieldName);
			return NameLineHeight + HeaderLineHeight + rows.arraySize * SingleLineHeight;
		}
		#endregion
	}
}