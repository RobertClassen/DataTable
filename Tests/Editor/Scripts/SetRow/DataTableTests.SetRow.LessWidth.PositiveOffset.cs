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

			const string expected = 
				"0 F G H I" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 1);

			AreEqual(expected, table);
		}

		[Test]
		public void SetRow_LessWidth_PositiveOffset3()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 F G" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 3);

			AreEqual(expected, table);
		}

		[Test]
		public void SetRow_LessWidth_PositiveOffset5()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 5);

			AreEqual(expected, table);
		}

		[Test]
		public void SetRow_LessWidth_PositiveOffset7()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I" }, 7);

			AreEqual(expected, table);
		}
	}
}