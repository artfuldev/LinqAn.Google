using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 93 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 93 refers the number/index of the custom dimension.")]
	public class Dimension93: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension93" />.
		/// </summary>
		public Dimension93(): base("Custom Dimension 93",true,"ga:dimension93")
		{
			
		}
	}
}

