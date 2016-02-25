using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 101 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 101 refers the number/index of the custom dimension.")]
	public class Dimension101: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension101" />.
		/// </summary>
		public Dimension101(): base("Custom Dimension 101",true,"ga:dimension101")
		{
			
		}
	}
}

