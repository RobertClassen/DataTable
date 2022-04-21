namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public class GameObjectTable : DataTable<GameObject>
	{
		public GameObjectTable(int width, int height) : base(width, height)
		{
		}
	}
}