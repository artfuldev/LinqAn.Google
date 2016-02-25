using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 1 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 1 refers the number/index of the custom dimension.")]
	public class Dimension1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension1" />.
		/// </summary>
		public Dimension1(): base("Custom Dimension 1",true,"ga:dimension1")
		{
			
		}
	}
}

