namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyRowTo_EqualSize_0Up1()
		{
			DataTable<string> table = Create5x3().Flip();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _";

			table.CopyRowTo(0, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyRowTo_EqualSize_1Up1()
		{
			DataTable<string> table = Create5x3().Flip();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"1 6 B" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _";

			table.CopyRowTo(1, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyRowTo_EqualSize_4Up1()
		{
			DataTable<string> table = Create5x3().Flip();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"4 9 E" + NewLine +
				"_ _ _";

			table.CopyRowTo(4, result, -1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}

		[Test]
		public void CopyRowTo_EqualSize_0Down1()
		{
			DataTable<string> table = Create5x3().Flip();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"_ _ _" + NewLine +
				"0 5 A" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _" + NewLine +
				"_ _ _";

			table.CopyRowTo(0, result, 1);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}
	}
}