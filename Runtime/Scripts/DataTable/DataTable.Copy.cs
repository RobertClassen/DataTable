namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <returns>The new instance.</returns>
		public DataTable<T> Copy()
		{
			return CopyTo(new DataTable<T>(Width, Height));
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> Copy(int xMin, int yMin, int xMax, int yMax, int xOffset, int yOffset)
		{
			return CopyTo(xMin, yMin, xMax, yMax, this, xOffset, yOffset);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyColumn(int x, int xOffset, int yMin = YMin)
		{
			return CopyColumn(x, xOffset, yMin, YMax);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyColumn(int x, int xOffset, int yMin, int yMax)
		{
			return CopyColumns(x, x, xOffset, yMin, yMax);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyColumns(int xMin, int xMax, int xOffset, int yMin = YMin)
		{
			return CopyColumns(xMin, xMax, xOffset, yMin, YMax);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyColumns(int xMin, int xMax, int xOffset, int yMin, int yMax)
		{
			return CopyTo(xMin, yMin, xMax, yMax, this, xOffset, Int.Zero);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyRow(int y, int yOffset, int xMin = XMin)
		{
			return CopyRow(y, yOffset, xMin, XMax);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyRow(int y, int yOffset, int xMin, int xMax)
		{
			return CopyRows(y, y, yOffset, xMin, xMax);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyRows(int yMin, int yMax, int yOffset, int xMin = XMin)
		{
			return CopyRows(yMin, yMax, yOffset, xMin, XMax);
		}

		/// <returns>The same instance.</returns>
		public DataTable<T> CopyRows(int yMin, int yMax, int yOffset, int xMin, int xMax)
		{
			return CopyTo(xMin, yMin, xMax, yMax, this, Int.Zero, yOffset);
		}
	}
}