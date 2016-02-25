using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 72 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 72 refers the number/index of the custom dimension.")]
	public class Dimension72: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension72" />.
		/// </summary>
		public Dimension72(): base("Custom Dimension 72",true,"ga:dimension72")
		{
			
		}
	}
}

