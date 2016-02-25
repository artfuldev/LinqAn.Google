using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 5 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 5 refers the number/index of the custom dimension.")]
	public class Dimension5: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension5" />.
		/// </summary>
		public Dimension5(): base("Custom Dimension 5",true,"ga:dimension5")
		{
			
		}
	}
}

