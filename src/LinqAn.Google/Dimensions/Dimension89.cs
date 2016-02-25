using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 89 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 89 refers the number/index of the custom dimension.")]
	public class Dimension89: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension89" />.
		/// </summary>
		public Dimension89(): base("Custom Dimension 89",true,"ga:dimension89")
		{
			
		}
	}
}

