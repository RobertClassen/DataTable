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
		public bool AddColumn(IList<T> items, int yOffset = Int.Zero)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Adds the <c>items</c> in a new row at the bottom.
		/// </summary>
		/// <param name="items">Items.</param>
		/// <param name="xOffset">X offset.</param>
		public void AddRow(IList<T> items, int xOffset = Int.Zero)
		{
			Row row = new Row(Width);

			int xMin = (XMin + xOffset).Clamp(items);
			int xMax = (Width + xOffset)/*.Clamp(items)*/;
			int iMin = (XMin - xOffset).Clamp(items);
			int iMax = (XMax - xOffset).Clamp(items);
			UnityEngine.Debug.Log("[" + xMin + ".." + xMax + "] = [" + iMin + ".." + iMax + "]");
			for(int x = xMin, i = iMin; x <= xMax && i <= iMax; x++, i++)
			{
				row[x] = items[i];
				UnityEngine.Debug.Log(x + " = " + i);
			}
			rows.Add(row);
		}
	}
}