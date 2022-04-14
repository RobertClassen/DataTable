namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class Vector4Table : DataTable<Vector4>
	{
		public Vector4Table(int width, int height) : base(width, height)
		{
		}
	}
}