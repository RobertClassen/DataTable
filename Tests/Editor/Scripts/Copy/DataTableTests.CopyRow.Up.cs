namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyRow_0Up1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRow(0, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRow_2Up1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"2 7 C" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRow(2, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRow_2Up2()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"2 7 C" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRow(2, -2);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRow_4Up1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"4 9 E" + NewLine +
				"4 9 E";

			table.CopyRow(4, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRow_4Up3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"4 9 E" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRow(4, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void CopyRow_4Up5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.CopyRow(4, -5);

			AreEqual(expected, table);
		}
	}
}