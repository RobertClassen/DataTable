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
		private const string NullReplacement = "[null]";
		private const bool reverseXDefault = false;
		private const bool reverseYDefault = false;
		#endregion

		#region Fields
		[SerializeField]
		protected List<Row> rows = new List<Row>();
		[SerializeField]
		protected List<string> headers = new List<string>();
		#endregion

		#region Properties
		public List<Row> Rows
		{ get { return rows; } }

		public T this[int x, int y, bool notify = true]
		{
			get { return rows[y][x]; }
			set
			{
				Row row = rows[y];
				if(!EqualityComparer<T>.Default.Equals(value, row[x]))
				{
					row[x] = value;
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

		public override List<string> Headers
		{
			get { return headers; }
			set { headers = value; }
		}
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