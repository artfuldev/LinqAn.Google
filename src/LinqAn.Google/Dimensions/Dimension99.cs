using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 99 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 99 refers the number/index of the custom dimension.")]
	public class Dimension99: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension99" />.
		/// </summary>
		public Dimension99(): base("Custom Dimension 99",true,"ga:dimension99")
		{
			
		}
	}
}

