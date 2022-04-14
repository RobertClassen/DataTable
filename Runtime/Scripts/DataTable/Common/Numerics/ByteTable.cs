namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	[Serializable]
	public class ByteTable : DataTable<byte>
	{
		public ByteTable(int width, int height) : base(width, height)
		{
		}
	}
}