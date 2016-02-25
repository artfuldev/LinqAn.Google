using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 138 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 138 refers the number/index of the custom dimension.")]
	public class Dimension138: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension138" />.
		/// </summary>
		public Dimension138(): base("Custom Dimension 138",true,"ga:dimension138")
		{
			
		}
	}
}

