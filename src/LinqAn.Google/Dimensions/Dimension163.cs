using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 163 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 163 refers the number/index of the custom dimension.")]
	public class Dimension163: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension163" />.
		/// </summary>
		public Dimension163(): base("Custom Dimension 163",true,"ga:dimension163")
		{
			
		}
	}
}

