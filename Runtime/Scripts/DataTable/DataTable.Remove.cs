namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Removes column <c>x</c>.
		/// </summary>
		/// <param name="x">The column to be removed.</param>
		/// <returns>The same instance.</returns>
		public DataTable<T> RemoveColumn(int x)
		{
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				rows[y].Cells.RemoveAt(x);
			}
			return this;
		}

		/// <summary>
		/// Removes <c>count</c> columns, starting from <c>x</c>, inclusively.
		/// </summary>
		/// <param name="x">The first column to be removed.</param>
		/// <param name = "count">The number of columns to be removed.</param>
		/// <returns>The same instance.</returns>
		public DataTable<T> RemoveColumnRange(int x, int count)
		{
			return RemoveColumns(x, count - x);
		}

		/// <summary>
		/// Removes all columns from <c>xMin</c> to <c>xMax</c>, inclusively.
		/// </summary>
		/// <param name="xMin">The first column to be removed.</param>
		/// <param name = "xMax">The last column to be removed.</param>
		/// <returns>The same instance.</returns>
		public DataTable<T> RemoveColumns(int xMin, int xMax)
		{
			VerifyXMinMax(xMin, xMax);
			for(int x = xMax; x >= xMin; x--)
			{
				RemoveColumn(x);
			}
			return this;
		}

		/// <summary>
		/// Removes row <c>y</c>.
		/// </summary>
		/// <param name="y">The row to be removed.</param>
		/// <returns>The same instance.</returns>
		public DataTable<T> RemoveRow(int y)
		{
			rows.RemoveAt(y);
			return this;
		}

		/// <summary>
		/// Removes <c>count</c> rows, starting from <c>y</c>, inclusively.
		/// </summary>
		/// <param name="y">The first row to be removed.</param>
		/// <param name = "count">The number of rows to be removed.</param>
		/// <returns>The same instance.</returns>
		public DataTable<T> RemoveRowRange(int y, int count)
		{
			return RemoveRows(y, count - y);
		}

		/// <summary>
		/// Removes all rows from <c>yMin</c> to <c>yMax</c>, inclusively.
		/// </summary>
		/// <param name="yMin">The first row to be removed.</param>
		/// <param name = "yMax">The last row to be removed.</param>
		/// <returns>The same instance.</returns>
		public DataTable<T> RemoveRows(int yMin, int yMax)
		{
			VerifyYMinMax(yMin, yMax);
			for(int y = yMax; y >= yMin; y--)
			{
				RemoveRow(y);
			}
			return this;
		}
	}
}