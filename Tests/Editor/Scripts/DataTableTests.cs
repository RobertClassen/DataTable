namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public class DataTableTests
	{
		[Test]
		public void ConstructorWorks()
		{
			const int width = 5;
			const int height = 3;
			DataTable<int> table = new DataTable<int>(width, height);

			Assert.NotNull(table);
			Assert.AreEqual(width, table.Width);
			Assert.AreEqual(height, table.Height);
			Assert.AreEqual(width * height, table.Capacity);
		}

		[Test]
		public void AssigningWorks()
		{
			const int width = 5;
			const int height = 3;
			DataTable<int> table = new DataTable<int>(width, height);

			int i = 0;
			for(int y = 0; y < table.Height; y++)
			{
				for(int x = 0; x < table.Width; x++)
				{
					Assert.DoesNotThrow(() => table[x, y] = i++);
				}
			}

			const string expected = "0\t1\t2\t3\t4\n5\t6\t7\t8\t9\n10\t11\t12\t13\t14";
			Assert.AreEqual(expected, table.ToString());
		}

		[Test]
		public void EqualsWorks()
		{
			const int width = 5;
			const int height = 3;
			DataTable<int> table0 = new DataTable<int>(width, height);
			DataTable<int> table1 = new DataTable<int>(width, height);

			Assert.IsTrue(table0.Equals(table1));

			table0[0, 0] = 10;
			Assert.IsFalse(table0.Equals(table1));

			table1[0, 0] = 10;
			Assert.IsTrue(table0.Equals(table1));
		}

		[Test]
		public void IndexOutOfRangeThrows()
		{
			const int width = 5;
			const int height = 3;
			DataTable<int> table = new DataTable<int>(width, height);

			Assert.Throws<IndexOutOfRangeException>(() => table[width, height] = 10);
		}
	}
}