namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
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
					rows[y][x] = default(T);
				}
			}
		}
	}
}