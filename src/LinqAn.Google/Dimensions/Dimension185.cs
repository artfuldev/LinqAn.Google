using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 185 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 185 refers the number/index of the custom dimension.")]
	public class Dimension185: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension185" />.
		/// </summary>
		public Dimension185(): base("Custom Dimension 185",true,"ga:dimension185")
		{
			
		}
	}
}

