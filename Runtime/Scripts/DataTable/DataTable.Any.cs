namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Checks if any cells fulfill the predicate.
		/// </summary>
		public bool Any(Func<T, bool> select)
		{
			int xMax = XMax;
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
				{
					if(select(rows[y][x]))
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Checks if any cells in the specified column fulfill the predicate.
		/// </summary>
		public bool AnyInColumn(int x, Func<T, bool> select)
		{
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				if(select(rows[y][x]))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Checks if any cells in the specified row fulfill the predicate.
		/// </summary>
		public bool AnyInRow(int y, Func<T, bool> select)
		{
			int xMax = XMax;
			for(int x = XMin; x <= xMax; x++)
			{
				if(select(rows[y][x]))
				{
					return true;
				}
			}
			return false;
		}
	}
}