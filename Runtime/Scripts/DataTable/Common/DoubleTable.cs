namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class DoubleTable : DataTable<double>
	{
		public DoubleTable(int width, int height) : base(width, height)
		{
		}
	}
}