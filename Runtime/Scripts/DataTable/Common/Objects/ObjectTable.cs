namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	/// <remarks>
	/// Unity cannot serialize <c>System.Object</c> 
	/// and therefore this class cannot be used in the Inspector 
	/// to set up any kind of data in the Editor.  
	/// 
	/// It can be used to hold data during Runtime operations, 
	/// however setting up (generating or loading) this data 
	/// as well as saving it must be handled manually, if necessary.
	/// </remarks>
	public class ObjectTable : DataTable<object>
	{
		public ObjectTable(int width, int height) : base(width, height)
		{
		}
	}
}