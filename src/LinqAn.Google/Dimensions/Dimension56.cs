using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 56 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 56 refers the number/index of the custom dimension.")]
	public class Dimension56: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension56" />.
		/// </summary>
		public Dimension56(): base("Custom Dimension 56",true,"ga:dimension56")
		{
			
		}
	}
}

