using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 49 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 49 refers the number/index of the custom dimension.")]
	public class Dimension49: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension49" />.
		/// </summary>
		public Dimension49(): base("Custom Dimension 49",true,"ga:dimension49")
		{
			
		}
	}
}

