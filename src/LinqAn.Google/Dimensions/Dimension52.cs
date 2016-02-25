using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 52 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 52 refers the number/index of the custom dimension.")]
	public class Dimension52: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension52" />.
		/// </summary>
		public Dimension52(): base("Custom Dimension 52",true,"ga:dimension52")
		{
			
		}
	}
}

