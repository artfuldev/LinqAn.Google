using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 170 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 170 refers the number/index of the custom dimension.")]
	public class Dimension170: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension170" />.
		/// </summary>
		public Dimension170(): base("Custom Dimension 170",true,"ga:dimension170")
		{
			
		}
	}
}

