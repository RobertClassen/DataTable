namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetRow_LessWidth_PositiveOffset1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 F G H I" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetRow_LessWidth_PositiveOffset3()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 F G" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetRow_LessWidth_PositiveOffset5()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void SetRow_LessWidth_PositiveOffset7()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}