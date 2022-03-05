namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using EverydayExtensions.Editor;
	using UnityEditor;
	using UnityEngine;
	using VectorMath;

	[CustomPropertyDrawer(typeof(DataTable.Row), true)]
	public class RowEditor : PropertyDrawer
	{
		#region Constants
		private const string CellsFieldName = "cells";
		private static readonly HashSet<Type> InlineTypes = new HashSet<Type> { 
			typeof(List<Color>), 
		};
		#endregion

		#region Fields
		private Type type = null;
		private bool isInlineType = false;
		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			using(new EditorGUI.PropertyScope(position, label, property))
			{
				SerializedProperty cells = property.FindPropertyRelative(CellsFieldName);
				if(cells == null)
				{
					EditorGUI.LabelField(position, "Could not find cells");
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
					SerializedProperty cell = cells.GetArrayElementAtIndex(x);
					Rect cellRect = position.GetColumn(x, xMax);
					if(!cell.hasChildren || isInlineType)
					{
						EditorGUI.PropertyField(cellRect, cell, GUIContent.none);
					}
					else
					{
						if(GUI.Button(cellRect, "Show"))
						{
							CellEditor.GetWindow(cell);
						}
					}

					//EditorGUI.LabelField(cellRect, cell.type);
				}
			}
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return base.GetPropertyHeight(property, label);
		}
		#endregion
	}
}