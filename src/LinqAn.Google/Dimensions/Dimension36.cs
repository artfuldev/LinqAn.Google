using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 36 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 36 refers the number/index of the custom dimension.")]
	public class Dimension36: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension36" />.
		/// </summary>
		public Dimension36(): base("Custom Dimension 36",true,"ga:dimension36")
		{
			
		}
	}
}

