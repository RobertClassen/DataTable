namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Swap()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"E 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D 0";

			table.Swap(0, 0, 4, 2);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void SwapColumns()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"1 0 2 3 4" + NewLine +
				"6 5 7 8 9" + NewLine +
				"B A C D E";

			table.SwapColumns(0, 1);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void SwapColumns_LimitedRows()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"1 0 2 3 4" + NewLine +
				"6 5 7 8 9" + NewLine +
				"A B C D E";

			table.SwapColumns(0, 1, 0, 1);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void SwapRows()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"5 6 7 8 9" + NewLine +
				"0 1 2 3 4" + NewLine +
				"A B C D E";

			table.SwapRows(0, 1);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void SwapRows_LimitedColumns()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"5 6 2 3 4" + NewLine +
				"0 1 7 8 9" + NewLine +
				"A B C D E";

			table.SwapRows(0, 1, 0, 1);

			Assert.AreEqual(expected, table.ToString(" "));
		}
	}
}