using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 51 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 51 refers the number/index of the custom dimension.")]
	public class Dimension51: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension51" />.
		/// </summary>
		public Dimension51(): base("Custom Dimension 51",true,"ga:dimension51")
		{
			
		}
	}
}

