using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 81 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 81 refers the number/index of the custom dimension.")]
	public class Dimension81: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension81" />.
		/// </summary>
		public Dimension81(): base("Custom Dimension 81",true,"ga:dimension81")
		{
			
		}
	}
}

