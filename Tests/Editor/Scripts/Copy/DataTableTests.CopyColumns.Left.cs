namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyColumns_0To0Left1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumns(0, 0, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumns_0To1Left1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"1 1 2 3 4" + NewLine +
				"6 6 7 8 9" + NewLine +
				"B B C D E";

			table.CopyColumns(0, 1, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumns_0To2Left1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"1 2 2 3 4" + NewLine +
				"6 7 7 8 9" + NewLine +
				"B C C D E";

			table.CopyColumns(0, 2, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumns_2To4Left1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 2 3 4 4" + NewLine +
				"5 7 8 9 9" + NewLine +
				"A C D E E";

			table.CopyColumns(2, 4, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumns_2To4Left3()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"3 4 2 3 4" + NewLine +
				"8 9 7 8 9" + NewLine +
				"D E C D E";

			table.CopyColumns(2, 4, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyColumns_2To4Left5()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumns(2, 4, -5);

			AreEqual(expected, table);
		}
	}
}