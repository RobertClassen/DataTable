namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetRow_EqualWidth_NegativeOffset1()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"G H I J 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I", "J" }, -1);

			AreEqual(expected, table);
		}

		[Test]
		public void SetRow_EqualWidth_NegativeOffset3()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"I J 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I", "J" }, -3);

			AreEqual(expected, table);
		}

		[Test]
		public void SetRow_EqualWidth_NegativeOffset5()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I", "J" }, -5);

			AreEqual(expected, table);
		}

		[Test]
		public void SetRow_EqualWidth_NegativeOffset7()
		{
			DataTable<string> table = Create5x3();

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I", "J" }, -7);

			AreEqual(expected, table);
		}
	}
}