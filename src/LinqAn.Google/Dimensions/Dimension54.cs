using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 54 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 54 refers the number/index of the custom dimension.")]
	public class Dimension54: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension54" />.
		/// </summary>
		public Dimension54(): base("Custom Dimension 54",true,"ga:dimension54")
		{
			
		}
	}
}

