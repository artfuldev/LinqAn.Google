using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 19 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 19 refers the number/index of the custom dimension.")]
	public class Dimension19: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension19" />.
		/// </summary>
		public Dimension19(): base("Custom Dimension 19",true,"ga:dimension19")
		{
			
		}
	}
}

