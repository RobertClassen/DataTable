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

			const string expected = 
				"_ _ _ _ _" + NewLine +
				"_ _ _ _ _" + NewLine +
				"_ _ _ _ _";

			table.Clear();

			AreEqual(expected, table);
		}

		[Test]
		public void ClearColumns()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"_ _ 2 3 4" + NewLine +
				"_ _ 7 8 9" + NewLine +
				"_ _ C D E";

			table.ClearColumns(0, 1);

			AreEqual(expected, table);
		}

		[Test]
		public void ClearColumns_LimitedRows()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"_ _ 2 3 4" + NewLine +
				"_ _ 7 8 9" + NewLine +
				"A B C D E";

			table.ClearColumns(0, 1, 0, 1);

			AreEqual(expected, table);
		}

		[Test]
		public void ClearRows()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"_ _ _ _ _" + NewLine +
				"_ _ _ _ _" + NewLine +
				"A B C D E";

			table.ClearRows(0, 1);

			AreEqual(expected, table);
		}

		[Test]
		public void ClearRows_LimitedColumns()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"_ _ 2 3 4" + NewLine +
				"_ _ 7 8 9" + NewLine +
				"A B C D E";

			table.ClearRows(0, 1, 0, 1);

			AreEqual(expected, table);
		}
	}
}