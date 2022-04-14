namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class FloatTable : DataTable<float>
	{
		public FloatTable(int width, int height) : base(width, height)
		{
		}
	}
}