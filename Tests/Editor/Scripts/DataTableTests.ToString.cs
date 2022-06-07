namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void ToString()
		{
			DataTable<string> table = Create5x3();

			const string expectedDefault = 
				"0\t1\t2\t3\t4" + NewLine +
				"5\t6\t7\t8\t9" + NewLine +
				"A\tB\tC\tD\tE";
			Assert.AreEqual(expectedDefault, table.ToString());

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";
			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void ToString_Null()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"_ _ _ _ _" + NewLine +
				"_ _ _ _ _" + NewLine +
				"_ _ _ _ _";

			table.Clear();

			AreEqual(expected, table);
		}
	}
}