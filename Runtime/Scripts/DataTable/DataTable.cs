namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NumericMath;

	public partial class DataTable<T> : Core.DataTable
	{
		#region Constants
		private const string ColumnSeparator = "\t";
		private const string RowSeparator = "\n";
		private const bool reverseXDefault = false;
		private const bool reverseYDefault = false;
		#endregion

		#region Fields
		protected T[][] cells = null;
		#endregion

		#region Properties
		public T[][] Cells
		{ get { return cells; } }

		public T this[int x, int y]
		{
			get { return cells[x][y]; }
			set { cells[x][y] = value; }
		}

		/// <summary>
		/// The number of columns.
		/// </summary>
		public override int Width
		{ get { return cells != null ? cells.Length : XMin; } }

		/// <summary>
		/// The number of rows.
		/// </summary>
		public override int Height
		{ get { return cells != null && cells[XMin] != null ? cells[XMin].Length : YMin; } }
		#endregion

		#region Constructors
		public DataTable(int width, int height)
		{
			cells = new T[width][];
			for(int x = Int.Zero; x < width; x++)
			{
				cells[x] = new T[height];
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Resets the values of all <see cref ="cells"/> to their <c>default(T)</c> value.
		/// </summary>
		public void Clear()
		{
			int xMax = XMax;
			int yMax = YMax;
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
				{
					cells[x][y] = default(T);
				}
			}
		}

		public void Resize(int width, int height)
		{
			if(width <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(width), width);
			}
			else if(height <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(height), height);
			}

			if(width == Width || height == Height)
			{
				return;
			}

			cells = CopyTo(new DataTable<T>(width, height)).cells;
		}

		public DataTable<T> CopyTo(DataTable<T> destination)
		{
			int width = Width;
			int height = Height;
			int newWidth = destination.Width;
			int newHeight = destination.Height;
			for(int y = Int.Zero; y < newHeight; y++)
			{
				for(int x = Int.Zero; x < newWidth; x++)
				{
					destination.cells[x][y] = x < width && y < height ? cells[x][y] : default(T);
				}
			}
			return destination;
		}

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
					array[i++] = cells[x][y];
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
					list.Add(cells[x][y]);
				}
			}
			return list;
		}

		/// <summary>
		/// Returns a <c>System.String</c> that represents the current <see cref="DataTable&lt;T&gt;"/>.
		/// </summary>
		public override string ToString()
		{
			return ToString(ColumnSeparator);
		}

		/// <summary>
		/// Returns a <c>System.String</c> that represents the current <see cref="DataTable&lt;T&gt;"/>.
		/// </summary>
		/// <param name="columnSeparator">Default is <see cref ="ColumnSeparator"/>.</param>
		public string ToString(string columnSeparator)
		{
			return string.Join(RowSeparator, EnumerateRows()
				.Select(row => string.Join(columnSeparator, row
					.Select(cell => !IsNullOrDefault(cell) ? cell.ToString() : default(T).ToString()))));
		}

		private static bool IsNullOrDefault(T cell)
		{
			return EqualityComparer<T>.Default.Equals(cell, default(T));
		}
		#endregion
	}
}