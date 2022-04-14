namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Object = UnityEngine.Object;

	[Serializable]
	public class UnityObjectTable : DataTable<Object>
	{
		public UnityObjectTable(int width, int height) : base(width, height)
		{
		}
	}
}