namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyColumnsTo_EqualSize_0To4Left1()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"1 2 3 4 _" + NewLine +
				"6 7 8 9 _" + NewLine +
				"B C D E _";

			table.CopyColumnsTo(1, 4, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumnsTo_EqualSize_0To4Left2()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"2 3 4 _ _" + NewLine +
				"7 8 9 _ _" + NewLine +
				"C D E _ _";

			table.CopyColumnsTo(1, 4, result, -2);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyColumnsTo_EqualSize_0To4Left5()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ _ _ _ _" + NewLine +
				"_ _ _ _ _" + NewLine +
				"_ _ _ _ _";

			table.CopyColumnsTo(1, 4, result, -5);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}
	}
}