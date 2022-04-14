namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class Vector3Table : DataTable<Vector3>
	{
		public Vector3Table(int width, int height) : base(width, height)
		{
		}
	}
}