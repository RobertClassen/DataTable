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
		/// <param name="items">Items.</param>
		/// <param name="yOffset">Y offset.</param>
		public void AddColumn(IList<T> items, int yOffset = Int.Zero)
		{
			int yMin = yOffset.Max(YMin);
			int yMax = (Height + yOffset).Min(YMax);
			int iMin = (-yOffset).Max(YMin);
			int iMax = (items.Count - yOffset).Min(items.Count - Int.One);
			for(int y = yMin, i = iMin; y <= yMax && i <= iMax; y++, i++)
			{
				rows[y].Cells.Add(items[i]);
			}
		}

		/// <summary>
		/// Adds the <c>items</c> in a new row at the bottom.
		/// </summary>
		/// <param name="items">Items.</param>
		/// <param name="xOffset">X offset.</param>
		public void AddRow(IList<T> items, int xOffset = Int.Zero)
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
		}
	}
}