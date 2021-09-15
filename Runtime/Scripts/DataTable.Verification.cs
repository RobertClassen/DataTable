namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Extensions;
	using System.Utilities;

	public partial class DataTable<T>
	{
		#region Constants
		private const string ArgumentOutOfRange = "Specified argument was out of the range of valid values.";
		#endregion

		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
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