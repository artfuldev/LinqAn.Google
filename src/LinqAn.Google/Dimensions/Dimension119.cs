using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 119 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 119 refers the number/index of the custom dimension.")]
	public class Dimension119: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension119" />.
		/// </summary>
		public Dimension119(): base("Custom Dimension 119",true,"ga:dimension119")
		{
			
		}
	}
}

