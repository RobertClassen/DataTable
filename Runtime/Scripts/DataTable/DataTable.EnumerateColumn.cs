namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Iterates the entire column <c>x</c>.
		/// </summary>
		/// <param name="x">The column to iterate.</param>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		public IEnumerable<T> EnumerateColumn(int x, bool reverseY = reverseYDefault)
		{
			return EnumerateColumn(x, YMin, YMax, reverseY);
		}

		/// <summary>
		/// Iterates column <c>x</c> from row <c>yMin</c> to row <c>yMax</c>, inclusively.
		/// </summary>
		/// <param name="x">The column to iterate.</param>
		/// <param name="yMin">The first row to iterate.</param>
		/// <param name="yMax">The last row to iterate.</param>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		public IEnumerable<T> EnumerateColumn(int x, int yMin, int yMax, bool reverseY = reverseYDefault)
		{
			VerifyX(x);
			VerifyYMinMax(yMin, yMax);

			if(!reverseY)
			{
				for(int y = yMin; y <= yMax; y++)
				{
					yield return rows[y][x];
				}
			}
			else
			{
				for(int y = yMax; y >= yMin; y--)
				{
					yield return rows[y][x];
				}
			}
		}

		/// <summary>
		/// Iterates all <see cref ="cells"/> by columns.
		/// </summary>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		public IEnumerable<IEnumerable<T>> EnumerateColumns(
			bool reverseX = reverseXDefault, bool reverseY = reverseYDefault)
		{
			return EnumerateColumns(XMin, XMax, reverseX, reverseY);
		}

		/// <summary>
		/// Iterates the columns between the specified <c>xMin</c> and <c>xMax</c> indices, inclusively.
		/// </summary>
		/// <param name="xMin">The first column to iterate.</param>
		/// <param name="xMax">The last column to iterate.</param>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		public IEnumerable<IEnumerable<T>> EnumerateColumns(int xMin, int xMax, 
			bool reverseX = reverseXDefault, bool reverseY = reverseYDefault)
		{
			return EnumerateColumns(xMin, xMax, YMin, YMax, reverseX, reverseY);
		}

		/// <summary>
		/// Iterates the <see cref ="cells"/> between the specified 
		/// <c>xMin</c>, <c>xMax</c>, <c>yMin</c>, and <c>yMax</c> indices by columns, inclusively.
		/// </summary>
		/// <param name="xMin">The first column to iterate.</param>
		/// <param name="xMax">The last column to iterate.</param>
		/// <param name="yMin">The first row to iterate.</param>
		/// <param name="yMax">The last row to iterate.</param>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		public IEnumerable<IEnumerable<T>> EnumerateColumns(int xMin, int xMax, int yMin, int yMax, 
			bool reverseX = reverseXDefault, bool reverseY = reverseYDefault)
		{
			VerifyXMinMax(xMin, xMax);

			if(!reverseX)
			{
				for(int x = xMin; x <= xMax; x++)
				{
					yield return EnumerateColumn(x, yMin, yMax, reverseY);
				}
			}
			else
			{
				for(int x = xMax; x >= xMin; x--)
				{
					yield return EnumerateColumn(x, yMin, yMax, reverseY);
				}
			}
		}
	}
}