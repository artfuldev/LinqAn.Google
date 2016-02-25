using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 108 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 108 refers the number/index of the custom dimension.")]
	public class Dimension108: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension108" />.
		/// </summary>
		public Dimension108(): base("Custom Dimension 108",true,"ga:dimension108")
		{
			
		}
	}
}

