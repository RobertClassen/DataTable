namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class StringTable : DataTable<string>
	{
		public StringTable(int width, int height) : base(width, height)
		{
		}
	}
}