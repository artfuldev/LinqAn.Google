using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 65 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 65 refers the number/index of the custom dimension.")]
	public class Dimension65: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension65" />.
		/// </summary>
		public Dimension65(): base("Custom Dimension 65",true,"ga:dimension65")
		{
			
		}
	}
}

