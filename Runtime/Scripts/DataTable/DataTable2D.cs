namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class DataTable2D<T> : DataTable<T>
	{
		#region Fields

		#endregion

		#region Properties
		public T this[Vector2Int coordinate]
		{
			get { return rows[coordinate.y][coordinate.x]; }
			set { rows[coordinate.y][coordinate.x] = value; }
		}

		public Vector2Int Size
		{ get { return new Vector2Int(Width, Height); } }

		public RectInt Rect
		{ get { return new RectInt(Vector2Int.zero, Size - Vector2Int.one); } }
		#endregion

		#region Constructors
		public DataTable2D(Vector2Int size) : base(size.x, size.y)
		{
		}
		#endregion

		#region Methods
		public bool IsClamped(Vector2Int coordinate)
		{
			return IsClampedX(coordinate.x) && IsClampedY(coordinate.y);
		}

		public void Resize(Vector2Int size)
		{
			Resize(size.x, size.y);
		}
		#endregion
	}
}