using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 9 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 9 refers the number/index of the custom dimension.")]
	public class Dimension9: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension9" />.
		/// </summary>
		public Dimension9(): base("Custom Dimension 9",true,"ga:dimension9")
		{
			
		}
	}
}

