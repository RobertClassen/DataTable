namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddColumn_EqualHeight_NegativeOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A G" + "\n" +
				"1 6 B H" + "\n" +
				"2 7 C I" + "\n" +
				"3 8 D J" + "\n" +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_EqualHeight_NegativeOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A I" + "\n" +
				"1 6 B J" + "\n" +
				"2 7 C _" + "\n" +
				"3 8 D _" + "\n" +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_EqualHeight_NegativeOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + "\n" +
				"1 6 B _" + "\n" +
				"2 7 C _" + "\n" +
				"3 8 D _" + "\n" +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_EqualHeight_NegativeOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + "\n" +
				"1 6 B _" + "\n" +
				"2 7 C _" + "\n" +
				"3 8 D _" + "\n" +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}