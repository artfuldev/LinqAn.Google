using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 48 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 48 refers the number/index of the custom dimension.")]
	public class Dimension48: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension48" />.
		/// </summary>
		public Dimension48(): base("Custom Dimension 48",true,"ga:dimension48")
		{
			
		}
	}
}

