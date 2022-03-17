namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Returns the index of the first cell in column <c>x</c> for which the <c>item</c> matches, else -1.
		/// </summary>
		public int IndexInColumn(int x, T item)
		{
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				if(item.Equals(rows[y][x]))
				{
					return y;
				}
			}
			return -1;
		}

		/// <summary>
		/// Returns the index of the first cell in column <c>x</c> for which the predicate is fulfilled, else -1.
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
		/// Returns the index of the first cell in row <c>y</c> for which the <c>item</c> matches, else -1.
		/// </summary>
		public int IndexInRow(int y, T item)
		{
			int xMax = XMax;
			for(int x = XMin; x <= xMax; x++)
			{
				if(item.Equals(rows[y][x]))
				{
					return x;
				}
			}
			return -1;
		}

		/// <summary>
		/// Returns the index of the first cell in row <c>y</c> for which the predicate is fulfilled, else -1.
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