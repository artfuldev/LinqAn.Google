using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 29 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 29 refers the number/index of the custom dimension.")]
	public class Dimension29: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension29" />.
		/// </summary>
		public Dimension29(): base("Custom Dimension 29",true,"ga:dimension29")
		{
			
		}
	}
}

