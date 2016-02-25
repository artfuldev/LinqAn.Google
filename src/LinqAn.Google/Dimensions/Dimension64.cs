using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 64 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 64 refers the number/index of the custom dimension.")]
	public class Dimension64: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension64" />.
		/// </summary>
		public Dimension64(): base("Custom Dimension 64",true,"ga:dimension64")
		{
			
		}
	}
}

