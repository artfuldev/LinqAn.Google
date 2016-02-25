using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 88 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 88 refers the number/index of the custom dimension.")]
	public class Dimension88: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension88" />.
		/// </summary>
		public Dimension88(): base("Custom Dimension 88",true,"ga:dimension88")
		{
			
		}
	}
}

