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
				"0 5 A G" + NewLine +
				"1 6 B H" + NewLine +
				"2 7 C I" + NewLine +
				"3 8 D J" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_EqualHeight_NegativeOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A I" + NewLine +
				"1 6 B J" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_EqualHeight_NegativeOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddColumn_EqualHeight_NegativeOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A _" + NewLine +
				"1 6 B _" + NewLine +
				"2 7 C _" + NewLine +
				"3 8 D _" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I", "J" }, -7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}