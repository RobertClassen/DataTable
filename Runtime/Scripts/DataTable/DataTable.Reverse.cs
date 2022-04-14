namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Reverses the <c>cells</c>, effectively rotating them by 180°, 
		/// keeping their <see cref ="Width"/> and <see cref ="Height"/>.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ▼ ▼ ▼ ▼ ▼ .<br/>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// E D C B A ◄<br/>
		/// 9 8 7 6 5 ◄<br/>
		/// 4 3 2 1 0 ◄<br/>
		/// . ▲ ▲ ▲ ▲ ▲<br/>
		/// </c>
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> Reverse()
		{
			int xMax = XMax;
			int yMax = YMax;
			int halfCapacity = Capacity / Two;
			int count = Int.Zero;

			Row current;
			Row opposite;
			T temp;
			for(int y = YMin; y <= yMax; y++)
			{
				current = rows[y];
				opposite = rows[yMax - y];
				for(int x = XMin; x <= xMax; x++)
				{
					int xReverse = xMax - x;
					temp = current[x];
					current[x] = opposite[xReverse];
					opposite[xReverse] = temp;

					if(++count >= halfCapacity)
					{
						return this;
					}
				}
			}
			return this;
		}

		/// <summary>
		/// Switches 'up' and 'down' of a single column.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ▼ . . . .<br/>
		/// 0 1 2 3 4<br/>
		/// 5 6 7 8 9<br/>
		/// A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// A 1 2 3 4<br/>
		/// 5 6 7 8 9<br/>
		/// 0 B C D E<br/>
		/// ▲ . . . .<br/>
		/// </c>
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> ReverseColumn(int x)
		{
			return ReverseColumns(x, x);
		}

		/// <summary>
		/// Switches 'up' and 'down' of all columns from <c>xMin</c> to the last one.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ▼ ▼ ▼ ▼ ▼<br/>
		/// 0 1 2 3 4<br/>
		/// 5 6 7 8 9<br/>
		/// A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// A B C D E<br/>
		/// 5 6 7 8 9<br/>
		/// 0 1 2 3 4<br/>
		/// ▲ ▲ ▲ ▲ ▲<br/>
		/// </c>
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> ReverseColumns(int xMin = XMin)
		{
			return ReverseColumns(xMin, XMax);
		}

		/// <summary>
		/// Switches 'up' and 'down' of all columns from <c>xMin</c> to <c>xMax</c>, inclusively.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ▼ ▼ ▼ ▼ ▼<br/>
		/// 0 1 2 3 4<br/>
		/// 5 6 7 8 9<br/>
		/// A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// A B C D E<br/>
		/// 5 6 7 8 9<br/>
		/// 0 1 2 3 4<br/>
		/// ▲ ▲ ▲ ▲ ▲<br/>
		/// </c>
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> ReverseColumns(int xMin, int xMax)
		{
			VerifyXMinMax(xMin, xMax);
			int yMax = YMax;
			int yHalf = yMax / Two;

			Row current;
			Row opposite;
			T temp;
			for(int y = YMin; y <= yHalf; y++)
			{
				current = rows[y];
				opposite = rows[yMax - y];
				for(int x = xMin; x <= xMax; x++)
				{
					temp = current[x];
					current[x] = opposite[x];
					opposite[x] = temp;
				}
			}
			return this;
		}

		/// <summary>
		/// Switches 'left' and 'right' of a single row.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// . 5 6 7 8 9<br/>
		/// . A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// 4 3 2 1 0 ◄<br/>
		/// 5 6 7 8 9 .<br/>
		/// A B C D E .<br/>
		/// </c>
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> ReverseRow(int y)
		{
			return ReverseRows(y, y);
		}

		/// <summary>
		/// Switches 'left' and 'right' of all rows from <c>yMin</c> to the last one.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// 4 3 2 1 0 ◄<br/>
		/// 9 8 7 6 5 ◄<br/>
		/// E D C B A ◄<br/>
		/// </c>
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> ReverseRows(int yMin = YMin)
		{
			return ReverseRows(yMin, YMax);
		}

		/// <summary>
		/// Switches 'left' and 'right' of all rows from <c>yMin</c> to <c>yMax</c>, inclusively.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// 4 3 2 1 0 ◄<br/>
		/// 9 8 7 6 5 ◄<br/>
		/// E D C B A ◄<br/>
		/// </c>
		/// </remarks>
		/// <returns>The same instance.</returns>
		public DataTable<T> ReverseRows(int yMin, int yMax)
		{
			VerifyYMinMax(yMin, yMax);

			int xMax = XMax;
			int xHalf = xMax / Two;

			Row row;
			T temp;
			for(int y = yMin; y <= yMax; y++)
			{
				row = rows[y];
				for(int x = XMin; x <= xHalf; x++)
				{
					int xReverse = xMax - x;
					temp = row[x];
					row[x] = row[xReverse];
					row[xReverse] = temp;
				}
			}
			return this;
		}
	}
}