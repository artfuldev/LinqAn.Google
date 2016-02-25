using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 13 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 13 refers the number/index of the custom dimension.")]
	public class Dimension13: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension13" />.
		/// </summary>
		public Dimension13(): base("Custom Dimension 13",true,"ga:dimension13")
		{
			
		}
	}
}

