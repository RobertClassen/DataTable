namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Assigns the <c>items</c> to column <c>x</c>.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> SetColumn(int x, IList<T> items, int yOffset = Int.Zero)
		{
			int yMin = Math.Max(YMin, yOffset);
			int yMax = Math.Min(YMax, Height + yOffset);
			int iMin = Math.Max(YMin, -yOffset);
			int iMax = Math.Min(items.Count - Int.One, items.Count - yOffset);
			for(int y = yMin, i = iMin; y <= yMax && i <= iMax; y++, i++)
			{
				rows[y][x] = items[i];
			}
			return this;
		}

		/// <summary>
		/// Assigns the <c>items</c> to column <c>x</c>.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> SetColumn(int x, params T[] items)
		{
			return SetColumn(x, items, Int.Zero);
		}

		/// <summary>
		/// Assigns the <c>items</c> to row <c>y</c>.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> SetRow(int y, IList<T> items, int xOffset = Int.Zero)
		{
			Row row = rows[y];
			int xMin = Math.Max(XMin, xOffset);
			int xMax = Math.Min(XMax, Width + xOffset);
			int iMin = Math.Max(XMin, -xOffset);
			int iMax = Math.Min(items.Count - Int.One, items.Count - xOffset);
			for(int x = xMin, i = iMin; x <= xMax && i <= iMax; x++, i++)
			{
				row[x] = items[i];
			}
			return this;
		}

		/// <summary>
		/// Assigns the <c>items</c> to row <c>y</c>.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> SetRow(int y, params T[] items)
		{
			return SetRow(y, items, Int.Zero);
		}
	}
}