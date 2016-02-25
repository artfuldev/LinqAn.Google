using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 168 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 168 refers the number/index of the custom dimension.")]
	public class Dimension168: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension168" />.
		/// </summary>
		public Dimension168(): base("Custom Dimension 168",true,"ga:dimension168")
		{
			
		}
	}
}

