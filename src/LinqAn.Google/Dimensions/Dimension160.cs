using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 160 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 160 refers the number/index of the custom dimension.")]
	public class Dimension160: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension160" />.
		/// </summary>
		public Dimension160(): base("Custom Dimension 160",true,"ga:dimension160")
		{
			
		}
	}
}

