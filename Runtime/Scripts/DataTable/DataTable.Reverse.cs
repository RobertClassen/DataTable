namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Reverses the <see cref ="cells"/>, effectively rotating them by 180°, 
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
		public void Reverse()
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
					temp = cells[x][y];
					cells[x][y] = cells[xReverse][yReverse];
					cells[xReverse][yReverse] = temp;

					if(++count >= halfCapacity)
					{
						return;
					}
				}
			}
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
		public void ReverseColumn(int x)
		{
			VerifyX(x);

			int yMax = YMax;
			int yHalf = yMax / Two;

			T temp;
			for(int y = YMin; y <= yHalf; y++)
			{
				int yReverse = yMax - y;
				temp = cells[x][y];
				cells[x][y] = cells[x][yReverse];
				cells[x][yReverse] = temp;
			}
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
		public void ReverseColumns()
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
					temp = cells[x][y];
					cells[x][y] = cells[x][yReverse];
					cells[x][yReverse] = temp;
				}
			}
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
		public void ReverseRow(int y)
		{
			VerifyY(y);

			int xMax = XMax;
			int xHalf = xMax / Two;

			T temp;
			for(int x = XMin; x <= xHalf; x++)
			{
				int xReverse = xMax - x;
				temp = cells[x][y];
				cells[x][y] = cells[xReverse][y];
				cells[xReverse][y] = temp;
			}
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
		public void ReverseRows()
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
					temp = cells[x][y];
					cells[x][y] = cells[xReverse][y];
					cells[xReverse][y] = temp;
				}
			}
		}
	}
}