using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 98 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 98 refers the number/index of the custom dimension.")]
	public class Dimension98: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension98" />.
		/// </summary>
		public Dimension98(): base("Custom Dimension 98",true,"ga:dimension98")
		{
			
		}
	}
}

