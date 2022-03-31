namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void AddRow_GreaterWidth_DefaultOffset()
		{
			DataTable<string> table = CreateDefault();

			const string expectedWithSpace = 
				"0 1 2 3 4" + "\n" +
				"5 6 7 8 9" + "\n" +
				"A B C D E" + "\n" +
				"F G H I J";

			table.AddRow(new []{ "F", "G", "H", "I", "J", "K" });

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}