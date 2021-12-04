namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Swaps the values of two individual cells.
		/// </summary>
		/// 
		/// <remarks>
		/// Use <see cref ="SwapColumns"/> or <see cref ="SwapRows"/> 
		/// if entire columns or rows need to be swapped at once.
		/// 
		/// <example>
		/// <code>
		/// //DataTable<char> chars = ...
		/// chars.Swap(0, 0, 4, 2);
		/// </code>
		/// </example>
		/// 
		/// Before:<br/>
		/// <c>
		/// . ▼ . . . . .<br/>
		/// ► 0 1 2 3 4 .<br/>
		/// . 5 6 7 8 9 .<br/>
		/// . A B C D E ◄<br/>
		/// . . . . . ▲ .<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// . ▼ . . . . .<br/>
		/// ► E 1 2 3 4 .<br/>
		/// . 5 6 7 8 9 .<br/>
		/// . A B C D 0 ◄<br/>
		/// . . . . . ▲ .<br/>
		/// </c>
		/// </remarks>
		public void Swap(int x0, int y0, int x1, int y1)
		{
			T temp = rows[y0][x0];
			rows[y0][x0] = rows[y1][x1];
			rows[y1][x1] = temp;
		}

		/// <summary>
		/// Swaps the values of the entire columns <c>x0</c> and <c>x1</c>.
		/// </summary>
		/// 
		/// <remarks>
		/// <example>
		/// <code>
		/// //DataTable<char> chars = ...
		/// chars.SwapColumns(0, 1);
		/// </code>
		/// </example>
		/// 
		/// Before:<br/>
		/// <c>
		/// ▼ ▼ . . .<br/>
		/// 0 1 2 3 4<br/>
		/// 5 6 7 8 9<br/>
		/// A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// ▼ ▼ . . .<br/>
		/// 1 0 2 3 4<br/>
		/// 6 5 7 8 9<br/>
		/// B A C D E<br/>
		/// </c>
		/// </remarks>
		public void SwapColumns(int x0, int x1)
		{
			SwapColumns(x0, x1, YMin, YMax);
		}

		/// <summary>
		/// Swaps the values of the columns <c>x0</c> and <c>x1</c> 
		/// between the rows <c>yMin</c> and <c>yMax</c>, inclusively.
		/// </summary>
		/// 
		/// <remarks>
		/// <example>
		/// <code>
		/// //DataTable<char> chars = ...
		/// chars.SwapColumns(0, 1, 0, 1);
		/// </code>
		/// </example>
		/// 
		/// Before:<br/>
		/// <c>
		/// . ▼ ▼ . . .<br/>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// . A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// . ▼ ▼ . . .<br/>
		/// ► 1 0 2 3 4<br/>
		/// ► 6 5 7 8 9<br/>
		/// . A B C D E<br/>
		/// </c>
		/// </remarks>
		public void SwapColumns(int x0, int x1, int yMin, int yMax)
		{
			VerifyX(x0);
			VerifyX(x1);
			VerifyYMinMax(yMin, yMax);

			T temp;
			for(int y = yMin; y <= yMax; y++)
			{
				temp = rows[y][x0];
				rows[y][x0] = rows[y][x1];
				rows[y][x1] = temp;
			}
		}

		/// <summary>
		/// Swaps the values of the entire rows <c>y0</c> and <c>y1</c>.
		/// </summary>
		/// 
		/// <remarks>
		/// <example>
		/// <code>
		/// //DataTable<char> chars = ...
		/// chars.SwapRows(0, 1);
		/// </code>
		/// </example>
		/// 
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// . A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// ► 5 6 7 8 9<br/>
		/// ► 0 1 2 3 4<br/>
		/// . A B C D E<br/>
		/// </c>
		/// </remarks>
		public void SwapRows(int y0, int y1)
		{
			SwapRows(y0, y1, XMin, XMax);
		}

		/// <summary>
		/// Swaps the values of the rows <c>y0</c> and <c>y1</c> 
		/// between the columns <c>xMin</c> and <c>xMax</c>, inclusively.
		/// </summary>
		/// 
		/// <remarks>
		/// <example>
		/// <code>
		/// //DataTable<char> chars = ...
		/// chars.SwapRows(0, 1, 0, 1);
		/// </code>
		/// </example>
		/// 
		/// Before:<br/>
		/// <c>
		/// . ▼ ▼ . . .<br/>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// . A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// . ▼ ▼ . . .<br/>
		/// ► 5 6 2 3 4<br/>
		/// ► 0 1 7 8 9<br/>
		/// . A B C D E<br/>
		/// </c>
		/// </remarks>
		public void SwapRows(int y0, int y1, int xMin, int xMax)
		{
			VerifyY(y0);
			VerifyY(y1);
			VerifyXMinMax(xMin, xMax);

			T temp;
			for(int x = xMin; x <= xMax; x++)
			{
				temp = rows[y0][x];
				rows[y0][x] = rows[y1][x];
				rows[y1][x] = temp;
			}
		}
	}
}