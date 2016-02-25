using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 86 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 86 refers the number/index of the custom dimension.")]
	public class Dimension86: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension86" />.
		/// </summary>
		public Dimension86(): base("Custom Dimension 86",true,"ga:dimension86")
		{
			
		}
	}
}

