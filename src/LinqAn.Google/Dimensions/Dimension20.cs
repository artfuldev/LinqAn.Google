using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 20 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 20 refers the number/index of the custom dimension.")]
	public class Dimension20: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension20" />.
		/// </summary>
		public Dimension20(): base("Custom Dimension 20",true,"ga:dimension20")
		{
			
		}
	}
}

