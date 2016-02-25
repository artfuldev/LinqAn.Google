using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 188 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 188 refers the number/index of the custom dimension.")]
	public class Dimension188: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension188" />.
		/// </summary>
		public Dimension188(): base("Custom Dimension 188",true,"ga:dimension188")
		{
			
		}
	}
}

