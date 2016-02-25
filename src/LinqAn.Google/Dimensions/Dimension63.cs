using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 63 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 63 refers the number/index of the custom dimension.")]
	public class Dimension63: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension63" />.
		/// </summary>
		public Dimension63(): base("Custom Dimension 63",true,"ga:dimension63")
		{
			
		}
	}
}

