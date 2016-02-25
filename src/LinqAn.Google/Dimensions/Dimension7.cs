using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 7 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 7 refers the number/index of the custom dimension.")]
	public class Dimension7: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension7" />.
		/// </summary>
		public Dimension7(): base("Custom Dimension 7",true,"ga:dimension7")
		{
			
		}
	}
}

