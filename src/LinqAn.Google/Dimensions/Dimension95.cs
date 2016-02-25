using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 95 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 95 refers the number/index of the custom dimension.")]
	public class Dimension95: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension95" />.
		/// </summary>
		public Dimension95(): base("Custom Dimension 95",true,"ga:dimension95")
		{
			
		}
	}
}

