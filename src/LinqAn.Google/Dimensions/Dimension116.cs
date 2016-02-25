using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 116 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 116 refers the number/index of the custom dimension.")]
	public class Dimension116: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension116" />.
		/// </summary>
		public Dimension116(): base("Custom Dimension 116",true,"ga:dimension116")
		{
			
		}
	}
}

