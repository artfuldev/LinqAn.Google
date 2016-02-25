using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 147 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 147 refers the number/index of the custom dimension.")]
	public class Dimension147: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension147" />.
		/// </summary>
		public Dimension147(): base("Custom Dimension 147",true,"ga:dimension147")
		{
			
		}
	}
}

