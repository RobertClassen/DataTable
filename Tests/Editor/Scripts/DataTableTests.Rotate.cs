namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void RotateLeft()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"4 9 E" + NewLine +
				"3 8 D" + NewLine +
				"2 7 C" + NewLine +
				"1 6 B" + NewLine +
				"0 5 A";

			table.RotateLeft();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void RotateRight()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"A 5 0" + NewLine +
				"B 6 1" + NewLine +
				"C 7 2" + NewLine +
				"D 8 3" + NewLine +
				"E 9 4";

			table.RotateRight();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}
	}
}