namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Extensions;
	using System.Utilities;

	public partial class DataTable<T> : Core.DataTable
	{
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

		public override int Width
		{ get { return cells != null ? cells.Length : Int.Zero; } }

		public override int Height
		{ get { return cells != null && cells[Int.Zero] != null ? cells[Int.Zero].Length : Int.Zero; } }
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

		public T[] ToArray()
		{
			int width = Width;
			int height = Height;
			T[] array = new T[Capacity];
			int i = Int.Zero;
			for(int y = Int.Zero; y < height; y++)
			{
				for(int x = Int.Zero; x < width; x++)
				{
					array[i++] = cells[x][y];
				}
			}
			return array;
		}

		public List<T> ToList()
		{
			int width = Width;
			int height = Height;
			List<T> list = new List<T>(Capacity);
			for(int y = Int.Zero; y < height; y++)
			{
				for(int x = Int.Zero; x < width; x++)
				{
					list.Add(cells[x][y]);
				}
			}
			return list;
		}
		#endregion
	}
}