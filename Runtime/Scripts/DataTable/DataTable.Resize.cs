namespace DataTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;

	public partial class DataTable<T>
	{
		/// <summary>
		/// Changes the number of columns and rows to the specified <c>width</c> and <c>height</c> values 
		/// if a resize is required.
		/// </summary>
		/// 
		/// <remarks>
		/// If they are smaller than the old sizes the extra <see cref ="cells"/> are removed.<br/>
		/// 
		/// If they are larger than the old sizes new <see cref ="cells"/> are added 
		/// and set to the <c>default(T)</c> value.<br/>
		/// </remarks>
		/// 
		/// <param name="width">The new number of columns.</param>
		/// <param name="height">The new number of rows.</param>
		/// <returns>The same instance.</returns>
		public DataTable<T> Resize(int width, int height)
		{
			if(width <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(width), width);
			}
			if(height <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(height), height);
			}

			if(width == Width && height == Height)
			{
				return this;
			}

			rows = CopyTo(new DataTable<T>(width, height)).rows;
			return this;
		}
	}
}