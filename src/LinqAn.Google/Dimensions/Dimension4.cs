using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 4 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 4 refers the number/index of the custom dimension.")]
	public class Dimension4: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension4" />.
		/// </summary>
		public Dimension4(): base("Custom Dimension 4",true,"ga:dimension4")
		{
			
		}
	}
}

