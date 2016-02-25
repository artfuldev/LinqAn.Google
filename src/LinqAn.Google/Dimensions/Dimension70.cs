using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 70 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 70 refers the number/index of the custom dimension.")]
	public class Dimension70: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension70" />.
		/// </summary>
		public Dimension70(): base("Custom Dimension 70",true,"ga:dimension70")
		{
			
		}
	}
}

