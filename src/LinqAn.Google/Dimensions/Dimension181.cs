using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 181 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 181 refers the number/index of the custom dimension.")]
	public class Dimension181: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension181" />.
		/// </summary>
		public Dimension181(): base("Custom Dimension 181",true,"ga:dimension181")
		{
			
		}
	}
}

