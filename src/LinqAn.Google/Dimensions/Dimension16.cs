using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 16 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 16 refers the number/index of the custom dimension.")]
	public class Dimension16: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension16" />.
		/// </summary>
		public Dimension16(): base("Custom Dimension 16",true,"ga:dimension16")
		{
			
		}
	}
}

