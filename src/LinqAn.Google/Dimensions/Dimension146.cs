using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 146 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 146 refers the number/index of the custom dimension.")]
	public class Dimension146: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension146" />.
		/// </summary>
		public Dimension146(): base("Custom Dimension 146",true,"ga:dimension146")
		{
			
		}
	}
}

