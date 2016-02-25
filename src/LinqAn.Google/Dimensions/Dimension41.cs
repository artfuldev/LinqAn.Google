using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 41 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 41 refers the number/index of the custom dimension.")]
	public class Dimension41: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension41" />.
		/// </summary>
		public Dimension41(): base("Custom Dimension 41",true,"ga:dimension41")
		{
			
		}
	}
}

