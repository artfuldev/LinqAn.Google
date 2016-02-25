using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 111 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 111 refers the number/index of the custom dimension.")]
	public class Dimension111: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension111" />.
		/// </summary>
		public Dimension111(): base("Custom Dimension 111",true,"ga:dimension111")
		{
			
		}
	}
}

