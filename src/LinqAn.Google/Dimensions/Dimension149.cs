using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 149 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 149 refers the number/index of the custom dimension.")]
	public class Dimension149: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension149" />.
		/// </summary>
		public Dimension149(): base("Custom Dimension 149",true,"ga:dimension149")
		{
			
		}
	}
}

