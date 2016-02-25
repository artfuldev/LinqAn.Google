using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 43 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 43 refers the number/index of the custom dimension.")]
	public class Dimension43: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension43" />.
		/// </summary>
		public Dimension43(): base("Custom Dimension 43",true,"ga:dimension43")
		{
			
		}
	}
}

