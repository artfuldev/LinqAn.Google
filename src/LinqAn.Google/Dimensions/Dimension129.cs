using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 129 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 129 refers the number/index of the custom dimension.")]
	public class Dimension129: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension129" />.
		/// </summary>
		public Dimension129(): base("Custom Dimension 129",true,"ga:dimension129")
		{
			
		}
	}
}

