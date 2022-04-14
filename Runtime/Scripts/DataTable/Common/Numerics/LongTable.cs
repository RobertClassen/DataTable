namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class LongTable : DataTable<long>
	{
		public LongTable(int width, int height) : base(width, height)
		{
		}
	}
}