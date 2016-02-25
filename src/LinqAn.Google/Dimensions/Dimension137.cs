using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 137 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 137 refers the number/index of the custom dimension.")]
	public class Dimension137: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension137" />.
		/// </summary>
		public Dimension137(): base("Custom Dimension 137",true,"ga:dimension137")
		{
			
		}
	}
}

