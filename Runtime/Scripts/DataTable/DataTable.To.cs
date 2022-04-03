namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Copies the contained elements into a new linear <c>T[]</c>.
		/// </summary>
		/// 
		/// <remarks>
		/// Iterates the <see cref ="cells"/> row by row (left to right, bottom to top).
		/// 
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// ► 0 1 2 3 4 5 6 7 8 9 A B C D E<br/>
		/// </c>
		/// </remarks>
		public T[] ToArray()
		{
			int xMax = XMax;
			int yMax = YMax;
			T[] array = new T[Capacity];
			int i = Int.Zero;
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
				{
					array[i++] = rows[y][x];
				}
			}
			return array;
		}

		/// <summary>
		/// Copies the contained elements into a new linear <c>List&lt;T&gt;</c>.
		/// </summary>
		/// 
		/// <remarks>
		/// Iterates the <see cref ="cells"/> row by row (left to right, bottom to top).
		/// 
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// ► 0 1 2 3 4 5 6 7 8 9 A B C D E<br/>
		/// </c>
		/// </remarks>
		public List<T> ToList()
		{
			int xMax = XMax;
			int yMax = YMax;
			List<T> list = new List<T>(Capacity);
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
				{
					list.Add(rows[y][x]);
				}
			}
			return list;
		}

		/// <summary>
		/// Returns a <c>System.String</c> that represents the <see cref="DataTable&lt;T&gt;"/> in a grid.
		/// </summary>
		public override string ToString()
		{
			return ToString(ColumnSeparator);
		}

		/// <summary>
		/// Returns a <c>System.String</c> that represents the <see cref="DataTable&lt;T&gt;"/> with custom separators.
		/// </summary>
		/// <param name="columnSeparator">Can be used to customize how columns are spaced apart. Default is <see cref ="ColumnSeparator"/>.</param>
		/// <param name = "nullReplacement">Can be used to customize how <c>null</c> <c>object</c>s are represented.</param>
		/// <param name = "rowSeparator">Can be used to customize how rows are separated.</param>
		public string ToString(string columnSeparator, string nullReplacement = NullReplacement, string rowSeparator = RowSeparator)
		{
			return string.Join(rowSeparator, EnumerateRows()
				.Select(row => string.Join(columnSeparator, row
					.Select(cell => cell?.ToString() ?? nullReplacement))));
		}
	}
}