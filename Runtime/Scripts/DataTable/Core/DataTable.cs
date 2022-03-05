namespace DataTypes.Core
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public abstract partial class DataTable : IEquatable<DataTable>
	{
		#region Constants
		private const string ArgumentOutOfRange = "Specified argument was out of the range of valid values.";
		/// <summary>
		/// The minimum valid column index.
		/// </summary>
		public const int XMin = Int.Zero;
		/// <summary>
		/// The minimum valid row index.
		/// </summary>
		public const int YMin = Int.Zero;
		protected const int Two = Int.One + Int.One;
		#endregion

		#region Fields

		#endregion

		#region Properties
		/// <summary>
		/// The number of columns.
		/// </summary>
		public abstract int Width { get; }

		/// <summary>
		/// The number of rows.
		/// </summary>
		public abstract int Height { get; }

		public int Capacity
		{ get { return Width * Height; } }

		/// <summary>
		/// The maximum valid column index.
		/// </summary>
		public int XMax
		{ get { return Width - Int.One; } }

		/// <summary>
		/// The maximum valid row index.
		/// </summary>
		public int YMax
		{ get { return Height - Int.One; } }
		#endregion

		#region Constructors

		#endregion

		#region Methods
		public bool Equals(DataTable other)
		{
			return other != null && (ReferenceEquals(this, other) || Width == other.Width && Height == other.Height);
		}

		/// <summary>
		/// Checks if the specified <c>x</c> is a valid column index.
		/// </summary>
		public bool IsClampedX(int x)
		{
			return x.IsClamped(XMin, XMax);
		}

		/// <summary>
		/// Checks if the specified <c>y</c> is a valid row index.
		/// </summary>
		public bool IsClampedY(int y)
		{
			return y.IsClamped(YMin, YMax);
		}

		/// <summary>
		/// Checks if the specified <c>x</c> and <c>y</c> are valid column and row indices.
		/// </summary>
		public bool IsClamped(int x, int y)
		{
			return IsClampedX(x) && IsClampedY(y);
		}

		protected void VerifyXMinMax(int xMin, int xMax)
		{
			if(!IsClampedX(xMin))
			{
				throw new ArgumentOutOfRangeException(nameof(xMin), xMin, ArgumentOutOfRange);
			}
			if(!IsClampedX(xMax))
			{
				throw new ArgumentOutOfRangeException(nameof(xMax), xMax, ArgumentOutOfRange);
			}
			if(xMin > xMax)
			{
				throw new ArgumentException(string.Format("{0} must be less than or equal to {1}", nameof(xMin), nameof(xMax)));
			}
		}

		protected void VerifyYMinMax(int yMin, int yMax)
		{
			if(!IsClampedY(yMin))
			{
				throw new ArgumentOutOfRangeException(nameof(yMin), yMin, ArgumentOutOfRange);
			}
			if(!IsClampedY(yMax))
			{
				throw new ArgumentOutOfRangeException(nameof(yMax), yMax, ArgumentOutOfRange);
			}
			if(yMin > yMax)
			{
				throw new ArgumentException(string.Format("{0} must be less than or equal to {1}", nameof(yMin), nameof(yMax)));
			}
		}

		protected void VerifyX(int x)
		{
			if(!IsClampedX(x))
			{
				throw new ArgumentOutOfRangeException(nameof(x), x, ArgumentOutOfRange);
			}
		}

		protected void VerifyY(int y)
		{
			if(!IsClampedY(y))
			{
				throw new ArgumentOutOfRangeException(nameof(y), y, ArgumentOutOfRange);
			}
		}
		#endregion
	}
}