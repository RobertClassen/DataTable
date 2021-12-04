namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
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
					flipped.cells[y][x] = cells[x][y];
				}
			}
			cells = flipped.cells;
		}

		/// <summary>
		/// Rotates the <see cref ="cells"/> counterclockwise, 
		/// swapping their <see cref ="Width"/> and <see cref ="Height"/>.
		/// </summary>
		/// 
		/// <remarks>
		/// To rotate twice use <see cref ="Reverse"/> instead.
		/// 
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// 4 9 E<br/>
		/// 3 8 D<br/>
		/// 2 7 C<br/>
		/// 1 6 B<br/>
		/// 0 5 A<br/>
		/// ▲ ▲ ▲<br/>
		/// </c>
		/// </remarks>
		public void RotateLeft()
		{
			int xMax = XMax;
			int yMax = YMax;
			DataTable<T> rotated = new DataTable<T>(Height, Width);
			for(int x = XMin; x <= xMax; x++)
			{
				int newX = xMax - x;
				for(int y = YMin; y <= yMax; y++)
				{
					rotated.cells[y][x] = cells[newX][y];
				}
			}
			cells = rotated.cells;
		}

		/// <summary>
		/// Rotates the <see cref ="cells"/> clockwise, 
		/// swapping their <see cref ="Width"/> and <see cref ="Height"/>.
		/// </summary>
		/// 
		/// <remarks>
		/// To rotate twice use <see cref ="Reverse"/> instead.
		/// 
		/// Before:<br/>
		/// <c>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// ▼ ▼ ▼<br/>
		/// A 5 0<br/>
		/// B 6 1<br/>
		/// C 7 2<br/>
		/// D 8 3<br/>
		/// E 9 4<br/>
		/// </c>
		/// </remarks>
		public void RotateRight()
		{
			int xMax = XMax;
			int yMax = YMax;
			DataTable<T> rotated = new DataTable<T>(Height, Width);
			for(int y = YMin; y <= yMax; y++)
			{
				int newY = yMax - y;
				for(int x = XMin; x <= xMax; x++)
				{
					rotated.cells[y][x] = cells[x][newY];
				}
			}
			cells = rotated.cells;
		}

		/// <summary>
		/// Rotates the <see cref ="cells"/> twice, 
		/// keeping their <see cref ="Width"/> and <see cref ="Height"/>.
		/// </summary>
		/// 
		/// <remarks>
		/// Before:<br/>
		/// <c>
		/// ▼ ▼ ▼ ▼ ▼ .<br/>
		/// ► 0 1 2 3 4<br/>
		/// ► 5 6 7 8 9<br/>
		/// ► A B C D E<br/>
		/// </c>
		/// 
		/// After:<br/>
		/// <c>
		/// E D C B A ◄<br/>
		/// 9 8 7 6 5 ◄<br/>
		/// 4 3 2 1 0 ◄<br/>
		/// . ▲ ▲ ▲ ▲ ▲<br/>
		/// </c>
		/// </remarks>
		[Obsolete("This wrapper method exists for discoverability. Call 'Reverse()' directly instead.")]
		public void RotateTwice()
		{
			Reverse();
		}
		#endregion
	}
}