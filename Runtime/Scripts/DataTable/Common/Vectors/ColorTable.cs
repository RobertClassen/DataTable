namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class ColorTable : DataTable<Color>
	{
		public ColorTable(int width, int height) : base(width, height)
		{
		}
	}
}