using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 83 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 83 refers the number/index of the custom dimension.")]
	public class Dimension83: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension83" />.
		/// </summary>
		public Dimension83(): base("Custom Dimension 83",true,"ga:dimension83")
		{
			
		}
	}
}

