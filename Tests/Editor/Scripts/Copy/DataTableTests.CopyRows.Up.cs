namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyRows_0To0Up1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRows(0, 0, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRows_0To1Up1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"1 6 B" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRows(0, 1, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRows_0To2Up1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRows(0, 2, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRows_2To4Up1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E" + NewLine +
				"4 9 E";

			table.CopyRows(2, 4, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRows_2To4Up3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"3 8 D" + NewLine +
				"4 9 E" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRows(2, 4, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRows_2To4Up5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRows(2, 4, -5);

			AreEqual(expected, table);
		}
	}
}