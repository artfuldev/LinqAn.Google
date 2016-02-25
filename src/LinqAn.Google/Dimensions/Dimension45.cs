using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 45 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 45 refers the number/index of the custom dimension.")]
	public class Dimension45: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension45" />.
		/// </summary>
		public Dimension45(): base("Custom Dimension 45",true,"ga:dimension45")
		{
			
		}
	}
}

