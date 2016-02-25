using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 180 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 180 refers the number/index of the custom dimension.")]
	public class Dimension180: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension180" />.
		/// </summary>
		public Dimension180(): base("Custom Dimension 180",true,"ga:dimension180")
		{
			
		}
	}
}

