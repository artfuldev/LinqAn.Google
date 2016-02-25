using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 14 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 14 refers the number/index of the custom dimension.")]
	public class Dimension14: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension14" />.
		/// </summary>
		public Dimension14(): base("Custom Dimension 14",true,"ga:dimension14")
		{
			
		}
	}
}

