using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 141 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 141 refers the number/index of the custom dimension.")]
	public class Dimension141: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension141" />.
		/// </summary>
		public Dimension141(): base("Custom Dimension 141",true,"ga:dimension141")
		{
			
		}
	}
}

