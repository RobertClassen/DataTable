namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public partial class DataTable<T> : Core.DataTable, IEquatable<DataTable<T>>
	{
		#region Constants
		private const string ColumnSeparator = "\t";
		private const string RowSeparator = "\n";
		private const bool reverseXDefault = false;
		private const bool reverseYDefault = false;
		#endregion

		#region Fields
		[SerializeField]
		protected List<Row> rows = new List<Row>();
		#endregion

		#region Properties
		public List<Row> Rows
		{ get { return rows; } }

		public T this[int x, int y, bool notify = true]
		{
			get { return rows[y][x]; }
			set
			{
				if(!value.Equals(rows[y][x]))
				{
					rows[y][x] = value;
					if(notify)
					{
						NotifyCellChangeListeners(x, y);
					}
				}
			}
		}

		/// <summary>
		/// The number of columns.
		/// </summary>
		public override int Width
		{ get { return rows != null && rows.Count > YMin && rows[YMin] != null ? rows[YMin].Width : XMin; } }

		/// <summary>
		/// The number of rows.
		/// </summary>
		public override int Height
		{ get { return rows != null ? rows.Count : YMin; } }
		#endregion

		#region Constructors
		public DataTable(int width, int height)
		{
			rows = new List<Row>(new Row[height]);
			for(int y = YMin; y <= YMax; y++)
			{
				rows[y] = new Row(width);
			}
		}
		#endregion
	}
}