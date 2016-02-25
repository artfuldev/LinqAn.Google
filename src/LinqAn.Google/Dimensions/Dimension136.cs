using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 136 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 136 refers the number/index of the custom dimension.")]
	public class Dimension136: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension136" />.
		/// </summary>
		public Dimension136(): base("Custom Dimension 136",true,"ga:dimension136")
		{
			
		}
	}
}

