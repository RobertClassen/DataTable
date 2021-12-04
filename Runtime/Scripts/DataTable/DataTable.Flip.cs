namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Switches the X and Y axes of the <see cref ="cells"/>, 
		/// swapping their <see cref ="Width"/> and <see cref ="Height"/>.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// . ▼ ▼ ▼ ▼ ▼<br/>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// . ▼ ▼ ▼<br/>
		/// ► 0 5 A<br/>
		/// ► 1 6 B<br/>
		/// ► 2 7 C<br/>
		/// ► 3 8 D<br/>
		/// ► 4 9 E<br/>
		/// </c>
		/// </remarks>
		public void Flip()
		{
			int xMax = XMax;
			int yMax = YMax;
			DataTable<T> flipped = new DataTable<T>(Height, Width);
			for(int y = YMin; y <= yMax; y++)
			{
				for(int x = XMin; x <= xMax; x++)
				{
					flipped.rows[x][y] = rows[y][x];
				}
			}
			rows = flipped.rows;
		}
	}
}