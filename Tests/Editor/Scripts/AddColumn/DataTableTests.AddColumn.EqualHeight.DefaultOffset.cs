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

			const string expected = 
				"0 5 A F" + NewLine +
				"1 6 B G" + NewLine +
				"2 7 C H" + NewLine +
				"3 8 D I" + NewLine +
				"4 9 E J";
			
			table.AddColumn(new []{ "F", "G", "H", "I", "J" });

			AreEqual(expected, table);
		}
	}
}