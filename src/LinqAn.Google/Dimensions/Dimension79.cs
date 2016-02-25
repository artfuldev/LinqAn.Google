using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 79 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 79 refers the number/index of the custom dimension.")]
	public class Dimension79: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension79" />.
		/// </summary>
		public Dimension79(): base("Custom Dimension 79",true,"ga:dimension79")
		{
			
		}
	}
}

