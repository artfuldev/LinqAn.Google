using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 66 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 66 refers the number/index of the custom dimension.")]
	public class Dimension66: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension66" />.
		/// </summary>
		public Dimension66(): base("Custom Dimension 66",true,"ga:dimension66")
		{
			
		}
	}
}

