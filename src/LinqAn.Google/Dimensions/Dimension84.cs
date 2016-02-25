using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 84 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 84 refers the number/index of the custom dimension.")]
	public class Dimension84: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension84" />.
		/// </summary>
		public Dimension84(): base("Custom Dimension 84",true,"ga:dimension84")
		{
			
		}
	}
}

