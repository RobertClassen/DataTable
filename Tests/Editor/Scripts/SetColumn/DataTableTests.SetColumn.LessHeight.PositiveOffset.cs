namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_LessHeight_PositiveOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"F 6 B" + NewLine +
				"G 7 C" + NewLine +
				"H 8 D" + NewLine +
				"I 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I" }, 1);

			AreEqual(expected, table);
		}

		[Test]
		public void SetColumn_LessHeight_PositiveOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"F 8 D" + NewLine +
				"G 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I" }, 3);

			AreEqual(expected, table);
		}

		[Test]
		public void SetColumn_LessHeight_PositiveOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I" }, 5);

			AreEqual(expected, table);
		}

		[Test]
		public void SetColumn_LessHeight_PositiveOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I" }, 7);

			AreEqual(expected, table);
		}
	}
}