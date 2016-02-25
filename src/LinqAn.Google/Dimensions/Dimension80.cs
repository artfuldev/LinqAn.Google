using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 80 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 80 refers the number/index of the custom dimension.")]
	public class Dimension80: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension80" />.
		/// </summary>
		public Dimension80(): base("Custom Dimension 80",true,"ga:dimension80")
		{
			
		}
	}
}

