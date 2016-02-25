using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 172 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 172 refers the number/index of the custom dimension.")]
	public class Dimension172: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension172" />.
		/// </summary>
		public Dimension172(): base("Custom Dimension 172",true,"ga:dimension172")
		{
			
		}
	}
}

