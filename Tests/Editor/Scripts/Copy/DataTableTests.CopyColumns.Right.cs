namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyColumns_4To4Right1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumns(4, 4, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumns_3To4Right1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 3" + NewLine +
				"5 6 7 8 8" + NewLine +
				"A B C D D";

			table.CopyColumns(3, 4, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumns_2To4Right1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 2 3" + NewLine +
				"5 6 7 7 8" + NewLine +
				"A B C C D";

			table.CopyColumns(2, 4, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumns_0To2Right1()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 0 1 2 4" + NewLine +
				"5 5 6 7 9" + NewLine +
				"A A B C E";

			table.CopyColumns(0, 2, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumns_0To2Right3()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 0 1" + NewLine +
				"5 6 7 5 6" + NewLine +
				"A B C A B";

			table.CopyColumns(0, 2, 3);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumns_0To2Right5()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyColumns(0, 2, 5);

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}