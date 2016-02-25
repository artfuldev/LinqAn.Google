using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 38 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 38 refers the number/index of the custom dimension.")]
	public class Dimension38: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension38" />.
		/// </summary>
		public Dimension38(): base("Custom Dimension 38",true,"ga:dimension38")
		{
			
		}
	}
}

