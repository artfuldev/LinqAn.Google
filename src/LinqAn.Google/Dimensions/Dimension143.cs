using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 143 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 143 refers the number/index of the custom dimension.")]
	public class Dimension143: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension143" />.
		/// </summary>
		public Dimension143(): base("Custom Dimension 143",true,"ga:dimension143")
		{
			
		}
	}
}

