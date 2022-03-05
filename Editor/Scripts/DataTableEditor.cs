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

				SerializedProperty rows = property.FindPropertyRelative("rows");
				int yMax = rows.arraySize;

				Rect headerRect = position.GetRow(0, yMax + 1);
				EditorGUI.LabelField(headerRect, label);

				for(int y = 0; y < yMax; y++)
				{
					//position.yMin += EditorGUIUtility.singleLineHeight;
					Rect rowRect = position.GetRow(y + 1, yMax + 1);
					EditorGUI.LabelField(rowRect, y.ToString());
					EditorGUI.PropertyField(rowRect.Indent(), rows.GetArrayElementAtIndex(y));
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