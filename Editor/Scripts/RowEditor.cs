namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEditor;
	using UnityEngine;
	using VectorMath;

	[CustomPropertyDrawer(typeof(DataTable.Row), true)]
	public class RowEditor : PropertyDrawer
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.DrawRect(position, 0.5f.Lerp(Color.red, Color.clear));

			SerializedProperty cells = property.FindPropertyRelative("cells");
			if(cells == null)
			{
				EditorGUI.LabelField(position, "Could not find cells");
				return;
			}

			int xMax = cells.arraySize;
			for(int x = 0; x < xMax; x++)
			{
				SerializedProperty cell = cells.GetArrayElementAtIndex(x);
				Rect cellRect = position.GetColumn(x, xMax);
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

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return base.GetPropertyHeight(property, label);
		}
		#endregion
	}
}