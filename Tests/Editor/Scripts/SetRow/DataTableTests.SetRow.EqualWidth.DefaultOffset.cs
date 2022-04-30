namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetRow_EqualWidth_DefaultOffset()
		{
			DataTable<string> table = Create5x3();

			const string expectedWithSpace = 
				"F G H I J" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";

			table.SetRow(0, new []{ "F", "G", "H", "I", "J" });

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}