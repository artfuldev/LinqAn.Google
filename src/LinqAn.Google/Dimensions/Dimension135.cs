using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 135 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 135 refers the number/index of the custom dimension.")]
	public class Dimension135: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension135" />.
		/// </summary>
		public Dimension135(): base("Custom Dimension 135",true,"ga:dimension135")
		{
			
		}
	}
}

