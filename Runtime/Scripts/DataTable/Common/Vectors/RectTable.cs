namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class RectTable : DataTable<Rect>
	{
		public RectTable(int width, int height) : base(width, height)
		{
		}
	}
}