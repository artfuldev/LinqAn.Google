using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 11 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 11 refers the number/index of the custom dimension.")]
	public class Dimension11: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension11" />.
		/// </summary>
		public Dimension11(): base("Custom Dimension 11",true,"ga:dimension11")
		{
			
		}
	}
}

