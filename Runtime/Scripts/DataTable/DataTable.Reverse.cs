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
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> Reverse()
		{
			int xMax = XMax;
			int yMax = YMax;
			int halfCapacity = Capacity / Two;
			int count = Int.Zero;

			T temp;
			for(int y = YMin; y <= yMax; y++)
			{
				int yReverse = yMax - y;
				for(int x = XMin; x <= xMax; x++)
				{
					int xReverse = xMax - x;
					temp = rows[y][x];
					rows[y][x] = rows[yReverse][xReverse];
					rows[yReverse][xReverse] = temp;

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
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> ReverseColumn(int x)
		{
			VerifyX(x);

			int yMax = YMax;
			int yHalf = yMax / Two;

			T temp;
			for(int y = YMin; y <= yHalf; y++)
			{
				int yReverse = yMax - y;
				temp = rows[y][x];
				rows[y][x] = rows[yReverse][x];
				rows[yReverse][x] = temp;
			}
			return this;
		}

		/// <summary>
		/// Switches 'up' and 'down' of all columns.
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
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> ReverseColumns()
		{
			int xMax = XMax;
			int yMax = YMax;
			int yHalf = yMax / Two;

			T temp;
			for(int y = YMin; y <= yHalf; y++)
			{
				int yReverse = yMax - y;
				for(int x = XMin; x <= xMax; x++)
				{
					temp = rows[y][x];
					rows[y][x] = rows[yReverse][x];
					rows[yReverse][x] = temp;
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
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> ReverseRow(int y)
		{
			VerifyY(y);

			int xMax = XMax;
			int xHalf = xMax / Two;

			T temp;
			for(int x = XMin; x <= xHalf; x++)
			{
				int xReverse = xMax - x;
				temp = rows[y][x];
				rows[y][x] = rows[y][xReverse];
				rows[y][xReverse] = temp;
			}
			return this;
		}

		/// <summary>
		/// Switches 'left' and 'right' of all rows.
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
		/// <returns>Returns the same instance.</returns>
		public DataTable<T> ReverseRows()
		{
			int xMax = XMax;
			int yMax = YMax;
			int xHalf = xMax / Two;

			T temp;
			for(int x = XMin; x <= xHalf; x++)
			{
				int xReverse = xMax - x;
				for(int y = YMin; y <= yMax; y++)
				{
					temp = rows[y][x];
					rows[y][x] = rows[y][xReverse];
					rows[y][xReverse] = temp;
				}
			}
			return this;
		}
	}
}