namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void ToString_Works()
		{
			DataTable<string> table = CreateDefault();

			const string expectedDefault = 
				"0\t1\t2\t3\t4" + "\n" +
				"5\t6\t7\t8\t9" + "\n" +
				"A\tB\tC\tD\tE";
			Assert.AreEqual(expectedDefault, table.ToString());

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E";
			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void ToString_Null_Works()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"_ _ _ _ _" + "\n" +
				"_ _ _ _ _" + "\n" +
				"_ _ _ _ _";

			table.Clear();

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}