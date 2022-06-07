namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class DataTableTests
	{
		private const string NewLine = "\n";
		private static readonly char[] hex = {
			'0', '1', '2', '3', '4', 
			'5', '6', '7', '8', '9', 
			'A', 'B', 'C', 'D', 'E',
		};

		private static DataTable<string> Create(int width, params string[] rows)
		{
			int height = rows.Length;
			DataTable<string> table = new DataTable<string>(width, height);
			char[] separator = { ' ' };
			for(int y = 0; y < table.Height; y++)
			{
				string[] cells = rows[y].Split(separator, width);
				for(int x = 0; x < table.Width; x++)
				{
					table[x, y] = cells[x];
				}
			}
			return table;
		}

		private static DataTable<string> Create5x3()
		{
			return Create(5, "0 1 2 3 4", "5 6 7 8 9", "A B C D E");
		}

		[Test]
		public void Create()
		{
			DataTable<string> table = Create5x3();

			Assert.AreEqual(15, table.Capacity);

			const string expected = 
				"0 1 2 3 4" + NewLine +
				"5 6 7 8 9" + NewLine +
				"A B C D E";
			Assert.AreEqual(expected, table.ToString(" "));
		}

		private static void AreEqual<T>(string expected, DataTable<T> table)
		{
			Assert.AreEqual(expected, table.ToString(" ", "_"));
		}
	}
}