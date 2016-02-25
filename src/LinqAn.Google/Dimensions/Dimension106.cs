using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 106 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 106 refers the number/index of the custom dimension.")]
	public class Dimension106: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension106" />.
		/// </summary>
		public Dimension106(): base("Custom Dimension 106",true,"ga:dimension106")
		{
			
		}
	}
}

