using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 15 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 15 refers the number/index of the custom dimension.")]
	public class Dimension15: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension15" />.
		/// </summary>
		public Dimension15(): base("Custom Dimension 15",true,"ga:dimension15")
		{
			
		}
	}
}

