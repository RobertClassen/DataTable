namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
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
					destination.rows[y][x] = x < width && y < height ? rows[y][x] : default(T);
				}
			}
			return destination;
		}
	}
}