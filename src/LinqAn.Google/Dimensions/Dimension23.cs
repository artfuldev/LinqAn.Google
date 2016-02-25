using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 23 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 23 refers the number/index of the custom dimension.")]
	public class Dimension23: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension23" />.
		/// </summary>
		public Dimension23(): base("Custom Dimension 23",true,"ga:dimension23")
		{
			
		}
	}
}

