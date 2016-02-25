using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 26 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 26 refers the number/index of the custom dimension.")]
	public class Dimension26: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension26" />.
		/// </summary>
		public Dimension26(): base("Custom Dimension 26",true,"ga:dimension26")
		{
			
		}
	}
}

