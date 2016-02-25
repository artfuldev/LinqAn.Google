using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 179 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 179 refers the number/index of the custom dimension.")]
	public class Dimension179: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension179" />.
		/// </summary>
		public Dimension179(): base("Custom Dimension 179",true,"ga:dimension179")
		{
			
		}
	}
}

