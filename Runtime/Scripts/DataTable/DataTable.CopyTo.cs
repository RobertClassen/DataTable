namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyColumnTo(int x, DataTable<T> destination, int xOffset, int yMin = YMin)
		{
			return CopyColumnTo(x, destination, xOffset, yMin, YMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyColumnTo(int x, DataTable<T> destination, int xOffset, int yMin, int yMax)
		{
			return CopyColumnsTo(x, x, destination, xOffset, yMin, yMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyColumnsTo(int xMin, int xMax, DataTable<T> destination, int xOffset)
		{
			return CopyColumnsTo(xMin, xMax, destination, xOffset, YMin, YMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyColumnsTo(int xMin, int xMax, DataTable<T> destination, int xOffset, int yMin = YMin)
		{
			return CopyColumnsTo(xMin, xMax, destination, xOffset, yMin, YMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyColumnsTo(int xMin, int xMax, DataTable<T> destination, int xOffset, int yMin, int yMax)
		{
			return CopyTo(xMin, yMin, xMax, yMax, destination, xOffset, Int.Zero);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyRowTo(int y, DataTable<T> destination, int yOffset, int xMin = XMin)
		{
			return CopyRowTo(y, destination, yOffset, xMin, XMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyRowTo(int y, DataTable<T> destination, int yOffset, int xMin, int xMax)
		{
			return CopyRowsTo(y, y, destination, yOffset, xMin, xMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyRowsTo(int yMin, int yMax, DataTable<T> destination, int yOffset)
		{
			return CopyRowsTo(yMin, yMax, destination, yOffset, XMin, XMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyRowsTo(int yMin, int yMax, DataTable<T> destination, int yOffset, int xMin = XMin)
		{
			return CopyRowsTo(yMin, yMax, destination, yOffset, xMin, XMax);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyRowsTo(int yMin, int yMax, DataTable<T> destination, int yOffset, int xMin, int xMax)
		{
			return CopyTo(xMin, yMin, xMax, yMax, destination, Int.Zero, yOffset);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyTo(DataTable<T> destination)
		{
			return CopyTo(XMin, YMin, XMax, YMax, destination, Int.Zero, Int.Zero);
		}

		/// <returns>The <c>destination</c> instance.</returns>
		public DataTable<T> CopyTo(int xMin, int yMin, int xMax, int yMax, DataTable<T> destination, int xOffset, int yOffset)
		{
			if(destination == this && xOffset == Int.Zero && yOffset == Int.Zero)
			{
				return destination;
			}

			VerifyXMinMax(xMin, xMax);
			VerifyYMinMax(yMin, yMax);

			int iMin = yMin + yOffset;
			int iMax = yMax + yOffset;
			int destinationYMax = destination.YMax;
			if(iMin < YMin)
			{
				yMin -= iMin;
				iMin = YMin;
			}
			if(iMax > destinationYMax)
			{
				yMax -= iMax - destinationYMax;
				iMax = destinationYMax;
			}

			if(yOffset < Int.Zero)
			{
				UnityEngine.Debug.Log(string.Format("U<-D old= [{0}..{1}]; new= [{2}..{3}]", xMin, xMax, iMin, iMax));
				for(int y = yMin, i = iMin; y <= yMax; y++, i++)
				{
					rows[y].CopyTo(xMin, xMax, destination.rows[i], xOffset);
				}
			}
			else
			{
				UnityEngine.Debug.Log(string.Format("U->D old= [{0}..{1}]; new= [{2}..{3}]", xMax, xMin, iMax, iMin));
				for(int y = yMax, i = iMax; y >= yMin; y--, i--)
				{
					rows[y].CopyTo(xMin, xMax, destination.rows[i], xOffset);
				}
			}
			return destination;
		}
	}
}