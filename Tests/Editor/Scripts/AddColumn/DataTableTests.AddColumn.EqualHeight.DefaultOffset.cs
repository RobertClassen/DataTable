namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddColumn_EqualHeight_DefaultOffset()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"0 5 A F" + "\n" +
				"1 6 B G" + "\n" +
				"2 7 C H" + "\n" +
				"3 8 D I" + "\n" +
				"4 9 E J";
			
			table.AddColumn(new []{ "F", "G", "H", "I", "J" });

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}