namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class RectIntTable : DataTable<RectInt>
	{
		public RectIntTable(int width, int height) : base(width, height)
		{
		}
	}
}