using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 165 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 165 refers the number/index of the custom dimension.")]
	public class Dimension165: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension165" />.
		/// </summary>
		public Dimension165(): base("Custom Dimension 165",true,"ga:dimension165")
		{
			
		}
	}
}

