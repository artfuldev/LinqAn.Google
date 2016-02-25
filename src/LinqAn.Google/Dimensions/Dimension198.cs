using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 198 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 198 refers the number/index of the custom dimension.")]
	public class Dimension198: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension198" />.
		/// </summary>
		public Dimension198(): base("Custom Dimension 198",true,"ga:dimension198")
		{
			
		}
	}
}

