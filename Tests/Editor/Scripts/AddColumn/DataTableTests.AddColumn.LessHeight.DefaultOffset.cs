namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddColumn_LessHeight_DefaultOffset()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A F" + NewLine +
				"1 6 B G" + NewLine +
				"2 7 C H" + NewLine +
				"3 8 D I" + NewLine +
				"4 9 E _";

			table.AddColumn(new []{ "F", "G", "H", "I" });

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}