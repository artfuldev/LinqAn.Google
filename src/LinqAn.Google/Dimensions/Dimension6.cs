using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 6 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 6 refers the number/index of the custom dimension.")]
	public class Dimension6: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension6" />.
		/// </summary>
		public Dimension6(): base("Custom Dimension 6",true,"ga:dimension6")
		{
			
		}
	}
}

