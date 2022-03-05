namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;
	using UnityEditor;
	using VectorMath;

	[CustomPropertyDrawer(typeof(DataTable), true)]
	public class DataTableEditor : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			using(new EditorGUI.PropertyScope(position, label, property))
			{
				GUI.Box(position, (string)null);
				//EditorGUI.DrawRect(position, Color.grey);
				//EditorGUI.DrawRect(position, Color.white);

				SerializedProperty rows = property.FindPropertyRelative("rows");
				int yMax = rows.arraySize;

				Rect headerRect = position.GetRow(0, yMax + 1);
				EditorGUI.LabelField(headerRect, label);

				for(int y = 0; y < yMax; y++)
				{
					//position.yMin += EditorGUIUtility.singleLineHeight;
					Rect rowRect = position.GetRow(y + 1, yMax + 1);
					EditorGUI.LabelField(rowRect, y.ToString());
					rowRect = rowRect.Indent();
					SerializedProperty row = rows.GetArrayElementAtIndex(y);
					SerializedProperty cells = row.FindPropertyRelative("cells");
					if(cells == null)
					{
						EditorGUI.LabelField(rowRect, "Could not find cells");
						continue;
					}
					int xMax = cells.arraySize;
					for(int x = 0; x < xMax; x++)
					{
						SerializedProperty cell = cells.GetArrayElementAtIndex(x);
						Rect cellRect = rowRect.GetColumn(x, xMax);
						if(!cell.hasChildren)
						{
							EditorGUI.PropertyField(cellRect, cell, GUIContent.none);
						}
						else
						{
							if(cell.isArray)
							{
								int count = cell.arraySize;
								EditorGUI.LabelField(cellRect, count.ToString());
							}
							else
							{
								int count = cell.CountInProperty();
								EditorGUI.LabelField(cellRect, count.ToString());
							}
						}

						//EditorGUI.LabelField(cellRect, cell.type);
					}
				}
			}
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			SerializedProperty rows = property.FindPropertyRelative("rows");
			int yMax = rows.arraySize;
			return (yMax + 1) * EditorGUIUtility.singleLineHeight;
		}
	}
}