namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_LessHeight_DefaultOffset()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"F 5 A" + "\n" +
				"G 6 B" + "\n" +
				"H 7 C" + "\n" +
				"I 8 D" + "\n" +
				"4 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I" });

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}