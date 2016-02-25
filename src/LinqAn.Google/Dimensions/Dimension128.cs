using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 128 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 128 refers the number/index of the custom dimension.")]
	public class Dimension128: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension128" />.
		/// </summary>
		public Dimension128(): base("Custom Dimension 128",true,"ga:dimension128")
		{
			
		}
	}
}

