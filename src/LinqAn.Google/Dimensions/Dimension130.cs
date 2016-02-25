using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 130 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 130 refers the number/index of the custom dimension.")]
	public class Dimension130: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension130" />.
		/// </summary>
		public Dimension130(): base("Custom Dimension 130",true,"ga:dimension130")
		{
			
		}
	}
}

