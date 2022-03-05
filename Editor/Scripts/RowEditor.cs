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
			//base.OnGUI(position, property, label);
			EditorGUI.DrawRect(position, 0.5f.Lerp(Color.red, Color.clear));
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return base.GetPropertyHeight(property, label);
		}
		#endregion
	}
}