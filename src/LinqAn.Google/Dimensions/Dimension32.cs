using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 32 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 32 refers the number/index of the custom dimension.")]
	public class Dimension32: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension32" />.
		/// </summary>
		public Dimension32(): base("Custom Dimension 32",true,"ga:dimension32")
		{
			
		}
	}
}

