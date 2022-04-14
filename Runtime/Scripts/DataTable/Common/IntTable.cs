namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class IntTable : DataTable<int>
	{
		public IntTable(int width, int height) : base(width, height)
		{
		}
	}
}