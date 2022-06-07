namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		//[Test]
		public void Copy()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"E 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D 0";

			//table.Copy(0, 0, 4, 2);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		//[Test]
		public void CopyColumns()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"1 0 2 3 4" + NewLine +
				"6 5 7 8 9" + NewLine +
				"B A C D E";

			//table.CopyColumns(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		//[Test]
		public void CopyColumns_LimitedRows()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"1 0 2 3 4" + NewLine +
				"6 5 7 8 9" + NewLine +
				"A B C D E";

			//table.CopyColumns(0, 1, 0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		//[Test]
		public void CopyRows()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"5 6 7 8 9" + NewLine +
				"0 1 2 3 4" + NewLine +
				"A B C D E";

			//table.CopyRows(0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}

		//[Test]
		public void CopyRows_LimitedColumns()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"5 6 2 3 4" + NewLine +
				"0 1 7 8 9" + NewLine +
				"A B C D E";

			//table.CopyRows(0, 1, 0, 1);

			Assert.AreEqual(expectedWithSpace, table.ToString(" "));
		}
	}
}