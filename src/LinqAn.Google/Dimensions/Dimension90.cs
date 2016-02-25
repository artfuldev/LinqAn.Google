using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 90 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 90 refers the number/index of the custom dimension.")]
	public class Dimension90: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension90" />.
		/// </summary>
		public Dimension90(): base("Custom Dimension 90",true,"ga:dimension90")
		{
			
		}
	}
}

