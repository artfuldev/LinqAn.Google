using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 97 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 97 refers the number/index of the custom dimension.")]
	public class Dimension97: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension97" />.
		/// </summary>
		public Dimension97(): base("Custom Dimension 97",true,"ga:dimension97")
		{
			
		}
	}
}

