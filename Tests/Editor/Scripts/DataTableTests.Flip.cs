namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Flip()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.Flip();

			Assert.AreEqual(expected, table.ToString(" "));
		}
	}
}