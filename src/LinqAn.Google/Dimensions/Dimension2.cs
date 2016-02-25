using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 2 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 2 refers the number/index of the custom dimension.")]
	public class Dimension2: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension2" />.
		/// </summary>
		public Dimension2(): base("Custom Dimension 2",true,"ga:dimension2")
		{
			
		}
	}
}

