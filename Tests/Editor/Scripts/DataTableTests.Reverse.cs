namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Reverse()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"E D C B A" + NewLine +
				"9 8 7 6 5" + NewLine +
				"4 3 2 1 0";

			table.Reverse();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void ReverseColumn()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"A 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"0 B C D E";

			table.ReverseColumn(0);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void ReverseColumns()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"A B C D E" + NewLine +
				"5 6 7 8 9" + NewLine +
				"0 1 2 3 4";

			table.ReverseColumns();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void ReverseRow()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"4 3 2 1 0" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.ReverseRow(0);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		[Test]
		public void ReverseRows()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"4 3 2 1 0" + NewLine +
				"9 8 7 6 5" + NewLine +
				"E D C B A";

			table.ReverseRows();

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}
	}
}