namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyColumn_0Right1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 0 2 3 4" + NewLine +
				"5 5 7 8 9" + NewLine +
				"A A C D E";

			table.CopyColumn(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumn_0Right3()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 0 4" + NewLine +
				"5 6 7 5 9" + NewLine +
				"A B C A E";

			table.CopyColumn(0, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumn_0Right5()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumn(0, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumn_2Right1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 2 4" + NewLine +
				"5 6 7 7 9" + NewLine +
				"A B C C E";

			table.CopyColumn(2, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumn_2Right2()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 2" + NewLine +
				"5 6 7 8 7" + NewLine +
				"A B C D C";

			table.CopyColumn(2, 2);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumn_4Right1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumn(4, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}