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

			const string expected = 
				"1 2 3 4" + NewLine +
				"6 7 8 9" + NewLine +
				"B C D E";

			table.RemoveColumn(0);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void RemoveColumns()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"2 3 4" + NewLine +
				"7 8 9" + NewLine +
				"C D E";

			table.RemoveColumns(0, 1);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void RemoveColumns_All()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"" + NewLine +
				"" + NewLine +
				"";

			table.RemoveColumns(0, 4);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void RemoveRow()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.RemoveRow(0);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void RemoveRows()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"A B C D E";

			table.RemoveRows(0, 1);

			Assert.AreEqual(expected, table.ToString(" "));
		}

		[Test]
		public void RemoveRows_All()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"";

			table.RemoveRows(0, 2);

			Assert.AreEqual(expected, table.ToString(" "));
		}
	}
}