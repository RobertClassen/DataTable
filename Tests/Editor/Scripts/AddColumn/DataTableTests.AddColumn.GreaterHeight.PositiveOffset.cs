namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddColumn_GreaterHeight_PositiveOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + NewLine +
				"1 6 B F" + NewLine +
				"2 7 C G" + NewLine +
				"3 8 D H" + NewLine +
				"4 9 E I";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_GreaterHeight_PositiveOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D F" + NewLine +
				"4 9 E G";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_GreaterHeight_PositiveOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_GreaterHeight_PositiveOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J", "K" }, 7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}