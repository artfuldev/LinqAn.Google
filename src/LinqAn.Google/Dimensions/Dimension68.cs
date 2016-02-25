using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 68 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 68 refers the number/index of the custom dimension.")]
	public class Dimension68: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension68" />.
		/// </summary>
		public Dimension68(): base("Custom Dimension 68",true,"ga:dimension68")
		{
			
		}
	}
}

