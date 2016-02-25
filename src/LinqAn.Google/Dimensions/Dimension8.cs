using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 8 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 8 refers the number/index of the custom dimension.")]
	public class Dimension8: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension8" />.
		/// </summary>
		public Dimension8(): base("Custom Dimension 8",true,"ga:dimension8")
		{
			
		}
	}
}

