namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		private const int HashSeed = 1009;
		private const int HashFactor = 9176;

		public virtual int GetColumnHashCode(int x)
		{
			int yMax = YMax;
			int hash = HashSeed;
			for(int y = YMin; y <= yMax; y++)
			{
				hash = (hash * HashFactor) + rows[y][x]?.GetHashCode() ?? Int.Zero;
			}
			return hash;
		}

		public virtual int GetRowHashCode(int y)
		{
			int xMax = XMax;
			int hash = HashSeed;
			Row row = rows[y];
			for(int x = XMin; x <= xMax; x++)
			{
				hash = (hash * HashFactor) + row[x]?.GetHashCode() ?? Int.Zero;
			}
			return hash;
		}
	}
}