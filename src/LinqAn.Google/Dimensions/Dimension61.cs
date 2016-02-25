using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 61 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 61 refers the number/index of the custom dimension.")]
	public class Dimension61: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension61" />.
		/// </summary>
		public Dimension61(): base("Custom Dimension 61",true,"ga:dimension61")
		{
			
		}
	}
}

