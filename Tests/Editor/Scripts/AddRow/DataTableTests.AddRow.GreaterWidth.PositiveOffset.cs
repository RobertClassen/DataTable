namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddRow_GreaterWidth_PositiveOffset1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"_ F G H I";

			table.AddRow(new []{ "F", "G", "H", "I", "J", "K" }, 1);

			AreEqual(expected, table);
		}

		[Test]
		public void AddRow_GreaterWidth_PositiveOffset3()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"_ _ _ F G";

			table.AddRow(new []{ "F", "G", "H", "I", "J", "K" }, 3);

			AreEqual(expected, table);
		}

		[Test]
		public void AddRow_GreaterWidth_PositiveOffset5()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I", "J", "K" }, 5);

			AreEqual(expected, table);
		}

		[Test]
		public void AddRow_GreaterWidth_PositiveOffset7()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E" + NewLine +
				"_ _ _ _ _";

			table.AddRow(new []{ "F", "G", "H", "I", "J", "K" }, 7);

			AreEqual(expected, table);
		}
	}
}