using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 156 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 156 refers the number/index of the custom dimension.")]
	public class Dimension156: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension156" />.
		/// </summary>
		public Dimension156(): base("Custom Dimension 156",true,"ga:dimension156")
		{
			
		}
	}
}

