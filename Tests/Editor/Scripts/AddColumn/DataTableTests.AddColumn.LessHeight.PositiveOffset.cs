namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddColumn_LessHeight_PositiveOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A _" + NewLine +
				"1 6 B F" + NewLine +
				"2 7 C G" + NewLine +
				"3 8 D H" + NewLine +
				"4 9 E I";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 1);

			AreEqual(expected, table);
		}

		[Test]
		public void AddColumn_LessHeight_PositiveOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D F" + NewLine +
				"4 9 E G";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 3);

			AreEqual(expected, table);
		}

		[Test]
		public void AddColumn_LessHeight_PositiveOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 5);

			AreEqual(expected, table);
		}

		[Test]
		public void AddColumn_LessHeight_PositiveOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 7);

			AreEqual(expected, table);
		}
	}
}