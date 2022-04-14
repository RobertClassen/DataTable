namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Resets the values of all <c>cells</c> to their <c>default(T)</c> value.
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> Clear()
		{
			return ClearRows(YMin, YMax, XMin, XMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in column <c>x</c> to their <c>default(T)</c> value 
		/// (for rows <c>yMin</c> to <see cref ="YMax"/>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearColumn(int x, int yMin = YMin)
		{
			return ClearColumn(x, yMin, YMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in column <c>x</c> to their <c>default(T)</c> value 
		/// (for rows <c>yMin</c> to <c>yMax</c>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearColumn(int x, int yMin, int yMax)
		{
			return ClearColumns(x, x, yMin, yMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in columns <c>xMin</c> to <c>xMax</c> 
		/// to their <c>default(T)</c> value 
		/// (for rows <c>yMin</c> to <see cref ="YMax"/>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearColumns(int xMin, int xMax, int yMin = YMin)
		{
			return ClearColumns(xMin, xMax, yMin, YMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in columns <c>xMin</c> to <c>xMax</c> 
		/// to their <c>default(T)</c> value 
		/// (for rows <c>yMin</c> to <c>yMax</c>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearColumns(int xMin, int xMax, int yMin, int yMax)
		{
			return ClearRows(yMin, yMax, xMin, xMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in row <c>y</c> to their <c>default(T)</c> value 
		/// (for rows <c>xMin</c> to <see cref ="XMax"/>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearRow(int y, int yMin = YMin)
		{
			return ClearRow(y, yMin, YMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in row <c>y</c> to their <c>default(T)</c> value 
		/// (for rows <c>xMin</c> to <c>xMax</c>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearRow(int y, int xMin, int xMax)
		{
			return ClearRows(y, y, xMin, xMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in rows <c>yMin</c> to <c>yMax</c> 
		/// to their <c>default(T)</c> value 
		/// (for rows <c>xMin</c> to <see cref ="XMax"/>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearRows(int yMin, int yMax, int xMin = XMin)
		{
			return ClearRows(yMin, yMax, xMin, XMax);
		}

		/// <summary>
		/// Resets the values of the <c>cells</c> in rows <c>yMin</c> to <c>yMax</c> 
		/// to their <c>default(T)</c> value 
		/// (for rows <c>xMin</c> to <c>xMax</c>).
		/// </summary>
		/// <returns>The same instance.</returns>
		public DataTable<T> ClearRows(int yMin, int yMax, int xMin, int xMax)
		{
			VerifyXMinMax(xMin, xMax);
			VerifyYMinMax(yMin, yMax);
			Row row;
			for(int y = yMin; y <= yMax; y++)
			{
				row = rows[y];
				for(int x = xMin; x <= xMax; x++)
				{
					row[x] = default(T);
				}
			}
			return this;
		}
	}
}