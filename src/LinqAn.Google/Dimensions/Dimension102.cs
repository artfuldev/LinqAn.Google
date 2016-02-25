using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 102 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 102 refers the number/index of the custom dimension.")]
	public class Dimension102: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension102" />.
		/// </summary>
		public Dimension102(): base("Custom Dimension 102",true,"ga:dimension102")
		{
			
		}
	}
}

