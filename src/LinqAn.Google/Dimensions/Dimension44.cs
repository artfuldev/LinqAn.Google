using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 44 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 44 refers the number/index of the custom dimension.")]
	public class Dimension44: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension44" />.
		/// </summary>
		public Dimension44(): base("Custom Dimension 44",true,"ga:dimension44")
		{
			
		}
	}
}

