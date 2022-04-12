namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Constructor()
		{
			const int width = 5;
			const int height = 3;
			DataTable<char> table = null;

			Assert.DoesNotThrow(() => table = new DataTable<char>(width, height));
			Assert.NotNull(table);
			Assert.AreEqual(width, table.Width);
			Assert.AreEqual(height, table.Height);
			Assert.AreEqual(width * height, table.Capacity);
		}
	}
}