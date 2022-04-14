namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_EqualHeight_PositiveOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + "\n" +
				"F 6 B" + "\n" +
				"G 7 C" + "\n" +
				"H 8 D" + "\n" +
				"I 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_EqualHeight_PositiveOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + "\n" +
				"1 6 B" + "\n" +
				"2 7 C" + "\n" +
				"F 8 D" + "\n" +
				"G 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_EqualHeight_PositiveOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + "\n" +
				"1 6 B" + "\n" +
				"2 7 C" + "\n" +
				"3 8 D" + "\n" +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_EqualHeight_PositiveOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + "\n" +
				"1 6 B" + "\n" +
				"2 7 C" + "\n" +
				"3 8 D" + "\n" +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, 7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}