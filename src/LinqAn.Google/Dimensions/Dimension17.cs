using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 17 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 17 refers the number/index of the custom dimension.")]
	public class Dimension17: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension17" />.
		/// </summary>
		public Dimension17(): base("Custom Dimension 17",true,"ga:dimension17")
		{
			
		}
	}
}

