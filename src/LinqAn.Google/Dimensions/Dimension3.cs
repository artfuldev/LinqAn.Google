using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 3 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 3 refers the number/index of the custom dimension.")]
	public class Dimension3: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension3" />.
		/// </summary>
		public Dimension3(): base("Custom Dimension 3",true,"ga:dimension3")
		{
			
		}
	}
}

