using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 100 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 100 refers the number/index of the custom dimension.")]
	public class Dimension100: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension100" />.
		/// </summary>
		public Dimension100(): base("Custom Dimension 100",true,"ga:dimension100")
		{
			
		}
	}
}

