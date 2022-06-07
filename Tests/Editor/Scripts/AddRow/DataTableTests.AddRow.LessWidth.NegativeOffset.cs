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
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"G H I _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void AddRow_LessWidth_NegativeOffset3()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"I _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void AddRow_LessWidth_NegativeOffset5()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -5);

			AreEqual(expected, table);
		}

		[Test]
		public void AddRow_LessWidth_NegativeOffset7()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I" }, -7);

			AreEqual(expected, table);
		}
	}
}