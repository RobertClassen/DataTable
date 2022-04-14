namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void GetColumnHashCode()
		{
			DataTable<string> table = Create5x3();

			Assert.AreEqual(-411653131, table.GetColumnHashCode(0));
			Assert.AreEqual(-495824576, table.GetColumnHashCode(1));
			Assert.AreEqual(-243236825, table.GetColumnHashCode(2));
			Assert.AreEqual(-327334870, table.GetColumnHashCode(3));
			Assert.AreEqual(-748338927, table.GetColumnHashCode(4));

			table[0, 0] = null;
			Assert.AreEqual(-385921419, table.GetColumnHashCode(0));
		}

		[Test]
		public void GetRowHashCode()
		{
			DataTable<string> table = Create5x3();

			Assert.AreEqual(311891762, table.GetRowHashCode(0));
			Assert.AreEqual(-1665475355, table.GetRowHashCode(1));
			Assert.AreEqual(-1848596599, table.GetRowHashCode(2));

			table[0, 0] = null;
			Assert.AreEqual(745453362, table.GetRowHashCode(0));
		}
	}
}