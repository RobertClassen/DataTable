namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	#if UNITY_EDITOR
	using UnityEditor;
	#endif

	[AttributeUsage(AttributeTargets.Field)]
	public abstract class CustomCellDrawerAttribute : PropertyAttribute
	{
		#if UNITY_EDITOR
		protected static readonly float SingleLineHeight = EditorGUIUtility.singleLineHeight;

		public abstract void DrawCell(Rect rect, SerializedProperty cell, DataTable dataTable, Vector2Int coordinate);

		public virtual float GetPropertyHeight(SerializedProperty cell, GUIContent label)
		{
			return SingleLineHeight;
		}
		#endif
	}
}