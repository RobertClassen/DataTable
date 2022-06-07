namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_GreaterHeight_NegativeOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"G 5 A" + NewLine +
				"H 6 B" + NewLine +
				"I 7 C" + NewLine +
				"J 8 D" + NewLine +
				"K 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void SetColumn_GreaterHeight_NegativeOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"I 5 A" + NewLine +
				"J 6 B" + NewLine +
				"K 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void SetColumn_GreaterHeight_NegativeOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"K 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, -5);

			AreEqual(expected, table);
		}

		[Test]
		public void SetColumn_GreaterHeight_NegativeOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, -7);

			AreEqual(expected, table);
		}
	}
}