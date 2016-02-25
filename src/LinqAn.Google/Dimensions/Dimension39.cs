using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 39 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 39 refers the number/index of the custom dimension.")]
	public class Dimension39: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension39" />.
		/// </summary>
		public Dimension39(): base("Custom Dimension 39",true,"ga:dimension39")
		{
			
		}
	}
}

