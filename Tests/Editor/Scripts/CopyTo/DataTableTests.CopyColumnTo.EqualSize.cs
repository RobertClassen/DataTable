namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyColumnTo_EqualSize_0Left1()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ _ _ _ _" + "\n" +
				"_ _ _ _ _" + "\n" +
				"_ _ _ _ _";

			table.CopyColumnTo(0, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumnTo_EqualSize_1Left1()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"1 _ _ _ _" + "\n" +
				"6 _ _ _ _" + "\n" +
				"B _ _ _ _";

			table.CopyColumnTo(1, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumnTo_EqualSize_4Left1()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ _ _ 4 _" + "\n" +
				"_ _ _ 9 _" + "\n" +
				"_ _ _ E _";

			table.CopyColumnTo(4, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumnTo_EqualSize_0Right1()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ 0 _ _ _" + "\n" +
				"_ 5 _ _ _" + "\n" +
				"_ A _ _ _";

			table.CopyColumnTo(0, result, 1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}
	}
}