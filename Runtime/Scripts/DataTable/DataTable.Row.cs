namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public partial class DataTable<T>
	{
		[Serializable]
		public class Row : Core.DataTable.Row
		{
			#region Fields
			[SerializeField]
			protected List<T> cells = null;
			#endregion

			#region Properties
			public List<T> Cells
			{ get { return cells; } }

			public int Width
			{ get { return cells.Count; } }

			public T this[int x]
			{
				get { return cells[x]; }
				set { cells[x] = value; }
			}
			#endregion

			#region Constructors
			public Row(int width)
			{
				cells = new List<T>(new T[width]);
			}
			#endregion

			#region Methods

			#endregion
		}
	}
}