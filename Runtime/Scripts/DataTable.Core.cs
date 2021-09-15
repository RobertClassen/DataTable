namespace DataTypes.Core
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Extensions;
	using System.Utilities;

	public abstract class DataTable
	{
		#region Constants
		/// <summary>
		/// The minimum valid column index.
		/// </summary>
		public const int XMin = Int.Zero;
		/// <summary>
		/// The minimum valid row index.
		/// </summary>
		public const int YMin = Int.Zero;
		#endregion

		#region Fields

		#endregion

		#region Properties
		public abstract int Width { get; }

		public abstract int Height { get; }

		public int Capacity
		{ get { return Width * Height; } }
		#endregion

		#region Constructors

		#endregion

		#region Methods
		public bool IsClampedX(int x)
		{
			return x.IsClamped(Int.Zero, Width - Int.One);
		}

		public bool IsClampedY(int y)
		{
			return y.IsClamped(Int.Zero, Height - Int.One);
		}

		public bool IsClamped(int x, int y)
		{
			return IsClampedX(x) && IsClampedY(y);
		}
		#endregion
	}
}