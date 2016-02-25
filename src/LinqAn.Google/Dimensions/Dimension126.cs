using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 126 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 126 refers the number/index of the custom dimension.")]
	public class Dimension126: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension126" />.
		/// </summary>
		public Dimension126(): base("Custom Dimension 126",true,"ga:dimension126")
		{
			
		}
	}
}

