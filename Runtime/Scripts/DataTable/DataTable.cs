namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T> : Core.DataTable, IEquatable<DataTable<T>>
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

		public bool Equals(DataTable<T> other)
		{
			if(!base.Equals(other))
			{
				return false;
			}

			int xMax = XMax;
			int yMax = YMax;
			EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
				{
					if(!equalityComparer.Equals(cells[x][y], other.cells[x][y]))
					{
						return false;
					}
				}
			}
			return true;
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
		#endregion
	}
}