namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_EqualHeight_NegativeOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"G 5 A" + "\n" +
				"H 6 B" + "\n" +
				"I 7 C" + "\n" +
				"J 8 D" + "\n" +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, -1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_EqualHeight_NegativeOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"I 5 A" + "\n" +
				"J 6 B" + "\n" +
				"2 7 C" + "\n" +
				"3 8 D" + "\n" +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, -3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_EqualHeight_NegativeOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + "\n" +
				"1 6 B" + "\n" +
				"2 7 C" + "\n" +
				"3 8 D" + "\n" +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, -5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_EqualHeight_NegativeOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + "\n" +
				"1 6 B" + "\n" +
				"2 7 C" + "\n" +
				"3 8 D" + "\n" +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" }, -7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}