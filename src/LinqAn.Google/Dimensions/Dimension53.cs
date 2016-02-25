using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 53 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 53 refers the number/index of the custom dimension.")]
	public class Dimension53: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension53" />.
		/// </summary>
		public Dimension53(): base("Custom Dimension 53",true,"ga:dimension53")
		{
			
		}
	}
}

