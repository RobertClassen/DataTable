namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void SetColumn_GreaterHeight_DefaultOffset()
		{
			DataTable<string> table = Create5x3().Flip();

			const string expected = 
				"F 5 A" + NewLine +
				"G 6 B" + NewLine +
				"H 7 C" + NewLine +
				"I 8 D" + NewLine +
				"J 9 E";

			table.SetColumn(0, new []{ "F", "G", "H", "I", "J", "K" });

			AreEqual(expected, table);
		}
	}
}