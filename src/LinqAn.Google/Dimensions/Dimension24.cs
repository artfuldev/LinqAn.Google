using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 24 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 24 refers the number/index of the custom dimension.")]
	public class Dimension24: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension24" />.
		/// </summary>
		public Dimension24(): base("Custom Dimension 24",true,"ga:dimension24")
		{
			
		}
	}
}

