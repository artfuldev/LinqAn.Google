using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 152 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 152 refers the number/index of the custom dimension.")]
	public class Dimension152: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension152" />.
		/// </summary>
		public Dimension152(): base("Custom Dimension 152",true,"ga:dimension152")
		{
			
		}
	}
}

