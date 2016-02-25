using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 33 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 33 refers the number/index of the custom dimension.")]
	public class Dimension33: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension33" />.
		/// </summary>
		public Dimension33(): base("Custom Dimension 33",true,"ga:dimension33")
		{
			
		}
	}
}

