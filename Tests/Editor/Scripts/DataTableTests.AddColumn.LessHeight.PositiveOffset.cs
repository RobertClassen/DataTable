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

			const string expectedWithSpace = 
				"0 5 A _" + "\n" +
				"1 6 B F" + "\n" +
				"2 7 C G" + "\n" +
				"3 8 D H" + "\n" +
				"4 9 E I";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_LessHeight_PositiveOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + "\n" +
				"1 6 B _" + "\n" +
				"2 7 C _" + "\n" +
				"3 8 D F" + "\n" +
				"4 9 E G";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_LessHeight_PositiveOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + "\n" +
				"1 6 B _" + "\n" +
				"2 7 C _" + "\n" +
				"3 8 D _" + "\n" +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_LessHeight_PositiveOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + "\n" +
				"1 6 B _" + "\n" +
				"2 7 C _" + "\n" +
				"3 8 D _" + "\n" +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I" }, 7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}