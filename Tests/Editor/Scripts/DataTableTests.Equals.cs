namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Equals()
		{
			const int width = 5;
			const int height = 3;
			DataTable<char> table0 = new DataTable<char>(width, height);
			DataTable<char> table1 = new DataTable<char>(width, height);

			Assert.IsTrue(table0.Equals(table0));
			Assert.IsTrue(table1.Equals(table1));

			Assert.IsFalse(table0.Equals(null));
			Assert.IsFalse(table0.Equals(null));

			Assert.IsTrue(table0.Equals(table1));

			table0[0, 0] = hex[10];
			Assert.IsFalse(table0.Equals(table1));

			table1[0, 0] = hex[10];
			Assert.IsTrue(table0.Equals(table1));
		}
	}
}