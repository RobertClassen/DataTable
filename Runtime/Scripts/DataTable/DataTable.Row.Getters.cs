namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		/// <summary>
		/// Iterates the entire row <c>y</c>.
		/// </summary>
		/// <param name="y">The row to iterate.</param>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		public IEnumerable<T> EnumerateRow(int y, bool reverseX = reverseXDefault)
		{
			return EnumerateRow(y, XMin, XMax, reverseX);
		}

		/// <summary>
		/// Iterates row <c>y</c> from column <c>xMin</c> to column <c>xMax</c>, inclusively.
		/// </summary>
		/// <param name="y">The row to iterate.</param>
		/// <param name="xMin">The first column to iterate.</param>
		/// <param name="xMax">The last column to iterate.</param>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		public IEnumerable<T> EnumerateRow(int y, int xMin, int xMax, bool reverseX = reverseXDefault)
		{
			VerifyY(y);
			VerifyXMinMax(xMin, xMax);

			if(!reverseX)
			{
				for(int x = xMin; x <= xMax; x++)
				{
					yield return cells[x][y];
				}
			}
			else
			{
				for(int x = xMax; x >= xMin; x--)
				{
					yield return cells[x][y];
				}
			}
		}

		/// <summary>
		/// Iterates all rows consecutively.
		/// </summary>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		public IEnumerable<IEnumerable<T>> EnumerateRows(
			bool reverseY = reverseYDefault, bool reverseX = reverseXDefault)
		{
			return EnumerateRows(YMin, YMax, reverseX, reverseY);
		}

		/// <summary>
		/// Iterates the rows between the specified <c>yMin</c> and <c>yMax</c> indices, inclusively.
		/// </summary>
		/// <param name="yMin">The first column to iterate.</param>
		/// <param name="yMax">The last column to iterate.</param>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		public IEnumerable<IEnumerable<T>> EnumerateRows(int yMin, int yMax, 
			bool reverseY = reverseYDefault, bool reverseX = reverseXDefault)
		{
			return EnumerateRows(yMin, yMax, XMin, XMax, reverseY, reverseX);
		}

		/// <summary>
		/// Iterates the <see cref ="cells"/> between the specified 
		/// <c>yMin</c>, <c>yMax</c>, <c>xMin</c>, and <c>xMax</c> indices by rows, inclusively.
		/// </summary>
		/// <param name="yMin">The first row to iterate.</param>
		/// <param name="yMax">The last row to iterate.</param>
		/// <param name="xMin">The first column to iterate.</param>
		/// <param name="xMax">The last column to iterate.</param>
		/// <param name="reverseY">Iterates top to bottom if set to <c>false</c>, else iterates bottom to top.</param>
		/// <param name="reverseX">Iterates left to right if set to <c>false</c>, else iterates right to left.</param>
		public IEnumerable<IEnumerable<T>> EnumerateRows(int yMin, int yMax, int xMin, int xMax, 
			bool reverseY = reverseYDefault, bool reverseX = reverseXDefault)
		{
			VerifyYMinMax(yMin, yMax);

			if(!reverseY)
			{
				for(int y = yMin; y <= yMax; y++)
				{
					yield return EnumerateRow(y, xMin, xMax, reverseX);
				}
			}
			else
			{
				for(int y = yMax; y >= yMin; y--)
				{
					yield return EnumerateRow(y, xMin, xMax, reverseX);
				}
			}
		}
		#endregion
	}
}