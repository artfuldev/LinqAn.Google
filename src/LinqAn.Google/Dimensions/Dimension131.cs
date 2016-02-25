using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 131 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 131 refers the number/index of the custom dimension.")]
	public class Dimension131: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension131" />.
		/// </summary>
		public Dimension131(): base("Custom Dimension 131",true,"ga:dimension131")
		{
			
		}
	}
}

