namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class ShortTable : DataTable<short>
	{
		public ShortTable(int width, int height) : base(width, height)
		{
		}
	}
}