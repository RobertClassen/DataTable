namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_GreaterHeight_PositiveOffset1()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + NewLine +
				"F 6 B" + NewLine +
				"G 7 C" + NewLine +
				"H 8 D" + NewLine +
				"I 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_GreaterHeight_PositiveOffset3()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"F 8 D" + NewLine +
				"G 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_GreaterHeight_PositiveOffset5()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetColumn_GreaterHeight_PositiveOffset7()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A" + NewLine +
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" }, 7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}