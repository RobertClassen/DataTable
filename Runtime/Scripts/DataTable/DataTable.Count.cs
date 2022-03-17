namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Returns the number of cells which contain the specified <c>item</c>.
		/// </summary>
		public int Count(T item)
		{
			int count = 0;
			int xMax = XMax;
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
				{
					if(item.Equals(rows[y][x]))
					{
						count++;
					}
				}
			}
			return count;
		}

		/// <summary>
		/// Returns the number of cells for which the predicate is fulfilled.
		/// </summary>
		public int Count(Func<T, bool> select)
		{
			int count = 0;
			int xMax = XMax;
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
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
		/// Returns the number of cells in column <c>x</c> which contain the specified <c>item</c>.
		/// </summary>
		public int CountInColumn(int x, T item)
		{
			int count = 0;
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				if(item.Equals(rows[y][x]))
				{
					count++;
				}
			}
			return count;
		}

		/// <summary>
		/// Returns the number of cells in column <c>x</c> for which the predicate is fulfilled.
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
		/// Returns the number of cells in row <c>y</c> which contain the specified <c>item</c>.
		/// </summary>
		public int CountInRow(int y, T item)
		{
			int count = 0;
			int xMax = XMax;
			for(int x = XMin; x <= xMax; x++)
			{
				if(item.Equals(rows[y][x]))
				{
					count++;
				}
			}
			return count;
		}

		/// <summary>
		/// Returns the number of cells in row <c>y</c> for which the predicate is fulfilled.
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