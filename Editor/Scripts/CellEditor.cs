namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEditor;
	using UnityEngine;

	public class CellEditor : EditorWindow
	{
		#region Constants
		private const string Title = "Cell Editor";
		#endregion

		#region Fields
		private SerializedProperty property = null;
		#endregion

		#region Properties

		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		[MenuItem("Tools/DataTable/" + Title)]
		public static void GetWindow()
		{
			CellEditor cellEditor = EditorWindow.GetWindow<CellEditor>(Title);
			cellEditor.ShowUtility();
		}

		public static void GetWindow(SerializedProperty property)
		{
			CellEditor cellEditor = EditorWindow.GetWindow<CellEditor>(Title);
			cellEditor.property = property;
			cellEditor.ShowUtility();
		}

		void OnGUI()
		{
			Draw();
		}

		private void Draw()
		{
			if(property == null)
			{
				EditorGUILayout.LabelField("No cell selected");
				return;
			}

			EditorGUILayout.PropertyField(property, GUIContent.none, true);
		}
		#endregion
	}
}