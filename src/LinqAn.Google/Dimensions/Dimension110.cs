using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 110 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 110 refers the number/index of the custom dimension.")]
	public class Dimension110: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension110" />.
		/// </summary>
		public Dimension110(): base("Custom Dimension 110",true,"ga:dimension110")
		{
			
		}
	}
}

