namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class CharTable : DataTable<char>
	{
		public CharTable(int width, int height) : base(width, height)
		{
		}
	}
}