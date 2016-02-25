using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 150 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 150 refers the number/index of the custom dimension.")]
	public class Dimension150: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension150" />.
		/// </summary>
		public Dimension150(): base("Custom Dimension 150",true,"ga:dimension150")
		{
			
		}
	}
}

