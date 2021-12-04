namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
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
					if(!equalityComparer.Equals(rows[y][x], other.rows[y][x]))
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}