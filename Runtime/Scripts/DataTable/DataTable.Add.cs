namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Adds the <c>items</c> in a new column on the right.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <param name="yOffset">Offsets the items by the specified number of rows.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddColumn(IList<T> items, int yOffset = Int.Zero)
		{
			int yMin = yOffset.Max(YMin);
			int yMax = (Height + yOffset).Min(YMax);
			int iMin = (-yOffset).Max(YMin);
			int iMax = (items.Count - yOffset).Min(items.Count - Int.One);
			for(int y = yMin, i = iMin; y <= yMax && i <= iMax; y++, i++)
			{
				rows[y].Cells.Add(items[i]);
			}
			return this;
		}

		/// <summary>
		/// Adds the <c>items</c> in a new column on the right.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddColumn(params T[] items)
		{
			return AddColumn(items);
		}

		/// <summary>
		/// Adds the <c>items</c> in a new row at the bottom.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <param name="xOffset">Offsets the items by the specified number of columns.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddRow(IList<T> items, int xOffset = Int.Zero)
		{
			Row row = new Row(Width);
			int xMin = xOffset.Max(XMin);
			int xMax = (Width + xOffset).Min(XMax);
			int iMin = (-xOffset).Max(XMin);
			int iMax = (items.Count - xOffset).Min(items.Count - Int.One);
			for(int x = xMin, i = iMin; x <= xMax && i <= iMax; x++, i++)
			{
				row[x] = items[i];
			}
			rows.Add(row);
			return this;
		}

		/// <summary>
		/// Adds the <c>items</c> in a new row at the bottom.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddRow(params T[] items)
		{
			return AddRow(items);
		}
	}
}