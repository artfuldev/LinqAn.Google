using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 162 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 162 refers the number/index of the custom dimension.")]
	public class Dimension162: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension162" />.
		/// </summary>
		public Dimension162(): base("Custom Dimension 162",true,"ga:dimension162")
		{
			
		}
	}
}

