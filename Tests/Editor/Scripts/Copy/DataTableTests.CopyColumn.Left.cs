namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyColumn_0Left1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumn(0, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumn_2Left1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 2 2 3 4" + NewLine +
				"5 7 7 8 9" + NewLine +
				"A C C D E";

			table.CopyColumn(2, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumn_2Left2()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"2 1 2 3 4" + NewLine +
				"7 6 7 8 9" + NewLine +
				"C B C D E";

			table.CopyColumn(2, -2);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumn_4Left1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 4 4" + NewLine +
				"5 6 7 9 9" + NewLine +
				"A B C E E";

			table.CopyColumn(4, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumn_4Left3()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 4 2 3 4" + NewLine +
				"5 9 7 8 9" + NewLine +
				"A E C D E";

			table.CopyColumn(4, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumn_4Left5()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumn(4, -5);

			AreEqual(expected, table);
		}
	}
}