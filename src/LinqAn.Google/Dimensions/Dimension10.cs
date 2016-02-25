using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 10 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 10 refers the number/index of the custom dimension.")]
	public class Dimension10: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension10" />.
		/// </summary>
		public Dimension10(): base("Custom Dimension 10",true,"ga:dimension10")
		{
			
		}
	}
}

