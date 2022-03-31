namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddRow_EqualWidth_PositiveOffset1()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"_ F G H I";

			table.AddRow(new []{ "F", "G", "H", "I", "J" }, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddRow_EqualWidth_PositiveOffset3()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"_ _ _ F G";

			table.AddRow(new []{ "F", "G", "H", "I", "J" }, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddRow_EqualWidth_PositiveOffset5()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I", "J" }, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddRow_EqualWidth_PositiveOffset7()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I", "J" }, 7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}