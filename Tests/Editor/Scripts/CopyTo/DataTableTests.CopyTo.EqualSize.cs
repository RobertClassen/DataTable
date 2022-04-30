namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void CopyTo_EqualSize()
		{
			DataTable<string> table = Create5x3();
			DataTable<string> result = new DataTable<string>(table.Width, table.Height);

			const string expectedWithSpace = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.CopyTo(0, 0, 4, 2, result, 0, 0);

			Assert.AreEqual(expectedWithSpace, result.ToString(" ", "_"));
		}
	}
}