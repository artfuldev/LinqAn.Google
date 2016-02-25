using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 192 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 192 refers the number/index of the custom dimension.")]
	public class Dimension192: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension192" />.
		/// </summary>
		public Dimension192(): base("Custom Dimension 192",true,"ga:dimension192")
		{
			
		}
	}
}

