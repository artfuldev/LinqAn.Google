using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 142 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 142 refers the number/index of the custom dimension.")]
	public class Dimension142: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension142" />.
		/// </summary>
		public Dimension142(): base("Custom Dimension 142",true,"ga:dimension142")
		{
			
		}
	}
}

