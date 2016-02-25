using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 104 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 104 refers the number/index of the custom dimension.")]
	public class Dimension104: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension104" />.
		/// </summary>
		public Dimension104(): base("Custom Dimension 104",true,"ga:dimension104")
		{
			
		}
	}
}

