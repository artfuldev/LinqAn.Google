using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 12 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 12 refers the number/index of the custom dimension.")]
	public class Dimension12: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension12" />.
		/// </summary>
		public Dimension12(): base("Custom Dimension 12",true,"ga:dimension12")
		{
			
		}
	}
}

