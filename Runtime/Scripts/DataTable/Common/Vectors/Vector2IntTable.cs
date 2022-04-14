namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class Vector2IntTable : DataTable<Vector2Int>
	{
		public Vector2IntTable(int width, int height) : base(width, height)
		{
		}
	}
}