namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class Vector3IntTable : DataTable<Vector3Int>
	{
		public Vector3IntTable(int width, int height) : base(width, height)
		{
		}
	}
}