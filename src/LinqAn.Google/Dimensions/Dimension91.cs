using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 91 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 91 refers the number/index of the custom dimension.")]
	public class Dimension91: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension91" />.
		/// </summary>
		public Dimension91(): base("Custom Dimension 91",true,"ga:dimension91")
		{
			
		}
	}
}

