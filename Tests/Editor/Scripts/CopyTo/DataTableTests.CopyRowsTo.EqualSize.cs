namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyRowsTo_EqualSize_0To4Up1()
		{
			DataTable<string> table = Create5x3().Flip();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"1 6 B" + NewLine +
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E" + NewLine +
				"_ _ _";

			table.CopyRowsTo(1, 4, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyRowsTo_EqualSize_0To4Up2()
		{
			DataTable<string> table = Create5x3().Flip();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"2 7 C" + NewLine +
				"3 8 D" + NewLine +
				"4 9 E" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _";

			table.CopyRowsTo(1, 4, result, -2);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyRowsTo_EqualSize_0To4Up5()
		{
			DataTable<string> table = Create5x3().Flip();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _";

			table.CopyRowsTo(1, 4, result, -5);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}
	}
}