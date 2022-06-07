namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddColumn_GreaterHeight_NegativeOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A G" + NewLine +
				"1 6 B H" + NewLine +
				"2 7 C I" + NewLine +
				"3 8 D J" + NewLine +
				"4 9 E K";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void AddColumn_GreaterHeight_NegativeOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A I" + NewLine +
				"1 6 B J" + NewLine +
				"2 7 C K" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void AddColumn_GreaterHeight_NegativeOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A K" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, -5);

			AreEqual(expected, table);
		}

		[Test]
		public void AddColumn_GreaterHeight_NegativeOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, -7);

			AreEqual(expected, table);
		}
	}
}