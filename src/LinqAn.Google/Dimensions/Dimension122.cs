using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 122 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 122 refers the number/index of the custom dimension.")]
	public class Dimension122: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension122" />.
		/// </summary>
		public Dimension122(): base("Custom Dimension 122",true,"ga:dimension122")
		{
			
		}
	}
}

