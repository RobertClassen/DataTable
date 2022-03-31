namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddRow_LessWidth_NegativeOffset1()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"G H I _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddRow_LessWidth_NegativeOffset3()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"I _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddRow_LessWidth_NegativeOffset5()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void AddRow_LessWidth_NegativeOffset7()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -7);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}