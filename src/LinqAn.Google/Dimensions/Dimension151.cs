using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 151 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 151 refers the number/index of the custom dimension.")]
	public class Dimension151: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension151" />.
		/// </summary>
		public Dimension151(): base("Custom Dimension 151",true,"ga:dimension151")
		{
			
		}
	}
}

