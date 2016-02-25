using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 127 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 127 refers the number/index of the custom dimension.")]
	public class Dimension127: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension127" />.
		/// </summary>
		public Dimension127(): base("Custom Dimension 127",true,"ga:dimension127")
		{
			
		}
	}
}

