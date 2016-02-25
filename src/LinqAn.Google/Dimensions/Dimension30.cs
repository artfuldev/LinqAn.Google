using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 30 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 30 refers the number/index of the custom dimension.")]
	public class Dimension30: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension30" />.
		/// </summary>
		public Dimension30(): base("Custom Dimension 30",true,"ga:dimension30")
		{
			
		}
	}
}

