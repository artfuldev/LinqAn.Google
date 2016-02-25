using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 85 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 85 refers the number/index of the custom dimension.")]
	public class Dimension85: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension85" />.
		/// </summary>
		public Dimension85(): base("Custom Dimension 85",true,"ga:dimension85")
		{
			
		}
	}
}

