using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 40 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 40 refers the number/index of the custom dimension.")]
	public class Dimension40: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension40" />.
		/// </summary>
		public Dimension40(): base("Custom Dimension 40",true,"ga:dimension40")
		{
			
		}
	}
}

