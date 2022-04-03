namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Adds a new empty column on the right.
		/// </summary>
		public DataTable<T> AddColumn()
		{
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				rows[y].Cells.Add(default(T));
			}
			return this;
		}

		/// <summary>
		/// Adds the <c>items</c> in a new column on the right.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.  
		/// The new column will be added first to avoid the internal jagged <c>List</c> becoming misaligned 
		/// in case of an exception when assigning the <c>items</c>.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <param name="yOffset">Offsets the items by the specified number of rows.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddColumn(IList<T> items, int yOffset = Int.Zero)
		{
			AddColumn();
			int yMin = yOffset.Max(YMin);
			int yMax = (Height + yOffset).Min(YMax);
			int iMin = (-yOffset).Max(YMin);
			int iMax = (items.Count - yOffset).Min(items.Count - Int.One);
			int xMax = XMax;
			for(int y = yMin, i = iMin; y <= yMax && i <= iMax; y++, i++)
			{
				rows[y][xMax] = items[i];
			}
			return this;
		}

		/// <summary>
		/// Adds the <c>items</c> in a new column on the right.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.  
		/// The new column will be added first to avoid the internal jagged <c>List</c> becoming misaligned 
		/// in case of an exception when assigning the <c>items</c>.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddColumn(params T[] items)
		{
			return AddColumn(items, Int.Zero);
		}

		/// <summary>
		/// Adds a new empty row at the bottom.
		/// </summary>
		public DataTable<T> AddRow()
		{
			rows.Add(new Row(Width));
			return this;
		}

		/// <summary>
		/// Adds the <c>items</c> in a new row at the bottom.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.  
		/// The new row will be added first to match the behavior of the <see cref ="AddColumn"/> method.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <param name="xOffset">Offsets the items by the specified number of columns.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddRow(IList<T> items, int xOffset = Int.Zero)
		{
			AddRow();
			Row row = rows[YMax];
			int xMin = xOffset.Max(XMin);
			int xMax = (Width + xOffset).Min(XMax);
			int iMin = (-xOffset).Max(XMin);
			int iMax = (items.Count - xOffset).Min(items.Count - Int.One);
			for(int x = xMin, i = iMin; x <= xMax && i <= iMax; x++, i++)
			{
				row[x] = items[i];
			}
			return this;
		}

		/// <summary>
		/// Adds the <c>items</c> in a new row at the bottom.
		/// </summary>
		/// <remarks>
		/// Items which are out of bounds will be ignored.  
		/// The new row will be added first to match the behavior of the <see cref ="AddColumn"/> method.
		/// </remarks>
		/// <param name="items">The items to be added.</param>
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> AddRow(params T[] items)
		{
			return AddRow(items, Int.Zero);
		}
	}
}