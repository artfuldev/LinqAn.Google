using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 75 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 75 refers the number/index of the custom dimension.")]
	public class Dimension75: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension75" />.
		/// </summary>
		public Dimension75(): base("Custom Dimension 75",true,"ga:dimension75")
		{
			
		}
	}
}

