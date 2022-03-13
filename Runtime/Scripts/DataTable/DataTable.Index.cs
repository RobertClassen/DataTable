namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Returns the index of first cell in the specified column for which the predicate is fulfilled, else -1.
		/// </summary>
		public int IndexInColumn(int x, Func<T, bool> select)
		{
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				if(select(rows[y][x]))
				{
					return y;
				}
			}
			return -1;
		}

		/// <summary>
		/// Returns the index of first cell in the specified row for which the predicate is fulfilled, else -1.
		/// </summary>
		public int IndexInRow(int y, Func<T, bool> select)
		{
			int xMax = XMax;
			for(int x = XMin; x <= xMax; x++)
			{
				if(select(rows[y][x]))
				{
					return x;
				}
			}
			return -1;
		}
	}
}