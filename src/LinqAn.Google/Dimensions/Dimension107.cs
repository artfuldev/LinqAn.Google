using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 107 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 107 refers the number/index of the custom dimension.")]
	public class Dimension107: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension107" />.
		/// </summary>
		public Dimension107(): base("Custom Dimension 107",true,"ga:dimension107")
		{
			
		}
	}
}

