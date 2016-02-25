using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 190 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 190 refers the number/index of the custom dimension.")]
	public class Dimension190: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension190" />.
		/// </summary>
		public Dimension190(): base("Custom Dimension 190",true,"ga:dimension190")
		{
			
		}
	}
}

