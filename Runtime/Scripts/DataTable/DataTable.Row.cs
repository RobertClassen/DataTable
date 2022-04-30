namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;
	using UnityEngine;

	public partial class DataTable<T>
	{
		[Serializable]
		public class Row
		{
			#region Constants
			/// <summary>
			/// The minimum valid column index.
			/// </summary>
			public const int XMin = Int.Zero;
			#endregion

			#region Fields
			[SerializeField]
			protected List<T> cells = null;
			#endregion

			#region Properties
			public List<T> Cells
			{ get { return cells; } }

			public int Width
			{ get { return cells.Count; } }

			/// <summary>
			/// The maximum valid column index.
			/// </summary>
			public int XMax
			{ get { return Width - Int.One; } }

			public T this[int x]
			{
				get { return cells[x]; }
				set { cells[x] = value; }
			}
			#endregion

			#region Constructors
			public Row(int width)
			{
				cells = new List<T>(new T[width]);
			}
			#endregion

			#region Methods
			internal void CopyTo(int xMin, int xMax, Row destination, int offset)
			{
				if(offset == Int.Zero && destination == this)
				{
					return;
				}

				int iMin = xMin + offset;
				int iMax = xMax + offset;
				int destinationXMax = destination.XMax;
				if(iMin < XMin)
				{
					xMin -= iMin;
					iMin = XMin;
				}
				if(iMax > destinationXMax)
				{
					xMax -= iMax - destinationXMax;
					iMax = destinationXMax;
				}

				if(offset < Int.Zero)
				{
					Debug.Log(string.Format("L<-R old= [{0}..{1}]; new= [{2}..{3}]", xMin, xMax, iMin, iMax));
					for(int x = xMin, i = iMin; x <= xMax; x++, i++)
					{
						Debug.Log(i + " <- " + x);
						destination[i] = cells[x];
					}
				}
				else
				{
					Debug.Log(string.Format("L->R old= [{0}..{1}]; new= [{2}..{3}]", xMax, xMin, iMax, iMin));
					for(int x = xMax, i = iMax; x >= xMin; x--, i--)
					{
						Debug.Log(i + " -> " + x);
						destination[i] = cells[x];
					}
				}
			}
			#endregion
		}
	}
}