namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Clear()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"_ _ _ _ _" + "\n" +
				"_ _ _ _ _" + "\n" +
				"_ _ _ _ _";

			table.Clear();

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void ClearColumns()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"_ _ 2 3 4" + "\n" +
				"_ _ 7 8 9" + "\n" +
				"_ _ C D E";

			table.ClearColumns(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void ClearColumns_LimitedRows()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"_ _ 2 3 4" + "\n" +
				"_ _ 7 8 9" + "\n" +
				"A B C D E";

			table.ClearColumns(0, 1, 0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void ClearRows()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"_ _ _ _ _" + "\n" +
				"_ _ _ _ _" + "\n" +
				"A B C D E";

			table.ClearRows(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void ClearRows_LimitedColumns()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"_ _ 2 3 4" + "\n" +
				"_ _ 7 8 9" + "\n" +
				"A B C D E";

			table.ClearRows(0, 1, 0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}