using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 25 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 25 refers the number/index of the custom dimension.")]
	public class Dimension25: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension25" />.
		/// </summary>
		public Dimension25(): base("Custom Dimension 25",true,"ga:dimension25")
		{
			
		}
	}
}

