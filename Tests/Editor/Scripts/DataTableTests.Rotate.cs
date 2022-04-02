namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void RotateLeft_Works()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"4 9 E" + "\n" +
				"3 8 D" + "\n" +
				"2 7 C" + "\n" +
				"1 6 B" + "\n" +
				"0 5 A";

			table.RotateLeft();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void RotateRight_Works()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"A 5 0" + "\n" +
				"B 6 1" + "\n" +
				"C 7 2" + "\n" +
				"D 8 3" + "\n" +
				"E 9 4";

			table.RotateRight();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}
	}
}