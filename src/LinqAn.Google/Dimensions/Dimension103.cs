using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 103 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 103 refers the number/index of the custom dimension.")]
	public class Dimension103: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension103" />.
		/// </summary>
		public Dimension103(): base("Custom Dimension 103",true,"ga:dimension103")
		{
			
		}
	}
}

