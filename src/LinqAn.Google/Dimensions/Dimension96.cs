using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 96 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 96 refers the number/index of the custom dimension.")]
	public class Dimension96: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension96" />.
		/// </summary>
		public Dimension96(): base("Custom Dimension 96",true,"ga:dimension96")
		{
			
		}
	}
}

