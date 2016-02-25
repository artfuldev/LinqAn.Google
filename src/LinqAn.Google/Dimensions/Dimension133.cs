using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 133 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 133 refers the number/index of the custom dimension.")]
	public class Dimension133: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension133" />.
		/// </summary>
		public Dimension133(): base("Custom Dimension 133",true,"ga:dimension133")
		{
			
		}
	}
}

