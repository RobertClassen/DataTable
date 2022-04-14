namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void RemoveColumn()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"1 2 3 4" + "\n" +
				"6 7 8 9" + "\n" +
				"B C D E";

			table.RemoveColumn(0);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void RemoveColumns()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"2 3 4" + "\n" +
				"7 8 9" + "\n" +
				"C D E";

			table.RemoveColumns(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void RemoveColumns_All()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"" + "\n" +
				"" + "\n" +
				"";

			table.RemoveColumns(0, 4);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void RemoveRow()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"5 6 7 8 9" + "\n" +
				"A B C D E";

			table.RemoveRow(0);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void RemoveRows()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"A B C D E";

			table.RemoveRows(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void RemoveRows_All()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"";

			table.RemoveRows(0, 2);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}
	}
}