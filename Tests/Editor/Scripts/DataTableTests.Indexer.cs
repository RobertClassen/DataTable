namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		[Test]
		public void Indexer()
		{
			const int width = 5;
			const int height = 3;
			DataTable<char> table = new DataTable<char>(width, height);

			int i = 0;
			for(int y = 0; y < table.Height; y++)
			{
				for(int x = 0; x < table.Width; x++)
				{
					Assert.DoesNotThrow(() => table[x, y] = hex[i++]);
				}
			}

			Assert.AreEqual(hex[0], table[0, 0]);
			Assert.AreEqual(hex[1], table[1, 0]);
			Assert.AreEqual(hex[2], table[2, 0]);
			Assert.AreEqual(hex[3], table[3, 0]);
			Assert.AreEqual(hex[4], table[4, 0]);
			Assert.AreEqual(hex[5], table[0, 1]);
			Assert.AreEqual(hex[6], table[1, 1]);
			Assert.AreEqual(hex[7], table[2, 1]);
			Assert.AreEqual(hex[8], table[3, 1]);
			Assert.AreEqual(hex[9], table[4, 1]);
			Assert.AreEqual(hex[10], table[0, 2]);
			Assert.AreEqual(hex[11], table[1, 2]);
			Assert.AreEqual(hex[12], table[2, 2]);
			Assert.AreEqual(hex[13], table[3, 2]);
			Assert.AreEqual(hex[14], table[4, 2]);
		}

		[Test]
		public void ArgumentOutOfRange_Throws()
		{
			const int width = 5;
			const int height = 3;
			DataTable<char> table = new DataTable<char>(width, height);

			Assert.Throws<ArgumentOutOfRangeException>(() => table[width, height] = hex[10]);
		}
	}
}