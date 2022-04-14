namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class Vector2Table : DataTable<Vector2>
	{
		public Vector2Table(int width, int height) : base(width, height)
		{
		}
	}
}