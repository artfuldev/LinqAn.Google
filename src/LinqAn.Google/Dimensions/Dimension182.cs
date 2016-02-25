using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 182 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 182 refers the number/index of the custom dimension.")]
	public class Dimension182: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension182" />.
		/// </summary>
		public Dimension182(): base("Custom Dimension 182",true,"ga:dimension182")
		{
			
		}
	}
}

