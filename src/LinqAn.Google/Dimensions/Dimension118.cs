using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 118 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 118 refers the number/index of the custom dimension.")]
	public class Dimension118: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension118" />.
		/// </summary>
		public Dimension118(): base("Custom Dimension 118",true,"ga:dimension118")
		{
			
		}
	}
}

