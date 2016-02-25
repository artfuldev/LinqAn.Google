using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 169 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 169 refers the number/index of the custom dimension.")]
	public class Dimension169: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension169" />.
		/// </summary>
		public Dimension169(): base("Custom Dimension 169",true,"ga:dimension169")
		{
			
		}
	}
}

