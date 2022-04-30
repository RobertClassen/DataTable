namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_EqualHeight_DefaultOffset()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expectedWithSpace = 
				"F 5 A" + NewLine +
				"G 6 B" + NewLine +
				"H 7 C" + NewLine +
				"I 8 D" + NewLine +
				"J 9 E";
			
			table.SetColumn(0, new []{ "F", "G", "H", "I", "J" });

			Assert.AreEqual(expectedWithSpace, table.ToString(" ", "_"));
		}
	}
}