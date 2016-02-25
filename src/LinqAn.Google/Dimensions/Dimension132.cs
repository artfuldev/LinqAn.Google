using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 132 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 132 refers the number/index of the custom dimension.")]
	public class Dimension132: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension132" />.
		/// </summary>
		public Dimension132(): base("Custom Dimension 132",true,"ga:dimension132")
		{
			
		}
	}
}

