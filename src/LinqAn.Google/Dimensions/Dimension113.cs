using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 113 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 113 refers the number/index of the custom dimension.")]
	public class Dimension113: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension113" />.
		/// </summary>
		public Dimension113(): base("Custom Dimension 113",true,"ga:dimension113")
		{
			
		}
	}
}

