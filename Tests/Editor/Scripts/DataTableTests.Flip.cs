namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Flip_Works()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 5 A" + "\n" +
				"1 6 B" + "\n" +
				"2 7 C" + "\n" +
				"3 8 D" + "\n" +
				"4 9 E";

			table.Flip();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}
	}
}