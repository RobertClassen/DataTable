namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class BoolTable : DataTable<bool>
	{
		public BoolTable(int width, int height) : base(width, height)
		{
		}
	}
}