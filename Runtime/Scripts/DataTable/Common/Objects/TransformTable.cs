namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class TransformTable : DataTable<Transform>
	{
		public TransformTable(int width, int height) : base(width, height)
		{
		}
	}
}