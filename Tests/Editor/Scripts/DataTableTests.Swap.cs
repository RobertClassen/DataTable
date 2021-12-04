namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Swap_Works()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"E 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D 0";

			table.Swap(0, 0, 4, 2);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void SwapColumns_Works()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"1 0 2 3 4" + "\n" +
				"6 5 7 8 9" + "\n" +
				"B A C D E";

			table.SwapColumns(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void SwapColumns_LimitedRows_Works()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"1 0 2 3 4" + "\n" +
				"6 5 7 8 9" + "\n" +
				"A B C D E";

			table.SwapColumns(0, 1, 0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void SwapRows_Works()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"5 6 7 8 9" + "\n" +
				"0 1 2 3 4" + "\n" +
				"A B C D E";

			table.SwapRows(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void SwapRows_LimitedColumns_Works()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"5 6 2 3 4" + "\n" +
				"0 1 7 8 9" + "\n" +
				"A B C D E";

			table.SwapRows(0, 1, 0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}
	}
}