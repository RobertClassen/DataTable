namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Checks if all cells contain the <c>item</c>.
		/// </summary>
		public bool All(T item)
		{
			int xMax = XMax;
			int yMax = YMax;
			Row row;
			for(int y = YMin; y <= yMax; y++)
			{
				row = rows[y];
				for(int x = XMin; x <= xMax; x++)
				{
					if(!item.Equals(rows[y][x]))
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>
		/// Checks if all cells fulfill the predicate.
		/// </summary>
		public bool All(Func<T, bool> select)
		{
			int xMax = XMax;
			int yMax = YMax;
			Row row;
			for(int y = YMin; y <= yMax; y++)
			{
				row = rows[y];
				for(int x = XMin; x <= xMax; x++)
				{
					if(!select(row[x]))
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>
		/// Checks if all cells in column <c>x</c> contain the <c>item</c>.
		/// </summary>
		public bool AllInColumn(int x, T item)
		{
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				if(!item.Equals(rows[y][x]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Checks if all cells in column <c>x</c> fulfill the predicate.
		/// </summary>
		public bool AllInColumn(int x, Func<T, bool> select)
		{
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				if(!select(rows[y][x]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Checks if all cells in row <c>y</c> contain the <c>item</c>.
		/// </summary>
		public bool AllInRow(int y, T item)
		{
			int xMax = XMax;
			Row row = rows[y];
			for(int x = XMin; x <= xMax; x++)
			{
				if(!item.Equals(row[x]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Checks if all cells in row <c>y</c> fulfill the predicate.
		/// </summary>
		public bool AllInRow(int y, Func<T, bool> select)
		{
			int xMax = XMax;
			Row row = rows[y];
			for(int x = XMin; x <= xMax; x++)
			{
				if(!select(row[x]))
				{
					return false;
				}
			}
			return true;
		}
	}
}