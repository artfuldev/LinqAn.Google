using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 50 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 50 refers the number/index of the custom dimension.")]
	public class Dimension50: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension50" />.
		/// </summary>
		public Dimension50(): base("Custom Dimension 50",true,"ga:dimension50")
		{
			
		}
	}
}

