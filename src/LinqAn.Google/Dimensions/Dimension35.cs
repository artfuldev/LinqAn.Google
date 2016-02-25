using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 35 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 35 refers the number/index of the custom dimension.")]
	public class Dimension35: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension35" />.
		/// </summary>
		public Dimension35(): base("Custom Dimension 35",true,"ga:dimension35")
		{
			
		}
	}
}

