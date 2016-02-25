using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 140 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 140 refers the number/index of the custom dimension.")]
	public class Dimension140: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension140" />.
		/// </summary>
		public Dimension140(): base("Custom Dimension 140",true,"ga:dimension140")
		{
			
		}
	}
}

