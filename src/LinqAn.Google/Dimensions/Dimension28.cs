using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 28 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 28 refers the number/index of the custom dimension.")]
	public class Dimension28: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension28" />.
		/// </summary>
		public Dimension28(): base("Custom Dimension 28",true,"ga:dimension28")
		{
			
		}
	}
}

