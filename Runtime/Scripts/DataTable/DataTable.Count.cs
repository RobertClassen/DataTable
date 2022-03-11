namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Returns the number of cells for which the predicate is fulfilled.
		/// </summary>
		public int Count(Func<T, bool> select)
		{
			int count = 0;
			int xMax = XMax;
			int yMax = YMax;
			for(int y = YMin; y <= xMax; y++)
			{
				for(int x = XMin; x <= yMax; x++)
				{
					if(select(rows[y][x]))
					{
						count++;
					}
				}
			}
			return count;
		}

		/// <summary>
		/// Returns the number of cells in the specified column for which the predicate is fulfilled.
		/// </summary>
		public int CountInColumn(int x, Func<T, bool> select)
		{
			int count = 0;
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				if(select(rows[y][x]))
				{
					count++;
				}
			}
			return count;
		}

		/// <summary>
		/// Returns the number of cells in the specified row for which the predicate is fulfilled.
		/// </summary>
		public int CountInRow(int y, Func<T, bool> select)
		{
			int count = 0;
			int xMax = XMax;
			for(int x = XMin; x <= xMax; x++)
			{
				if(select(rows[y][x]))
				{
					count++;
				}
			}
			return count;
		}
	}
}