using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 125 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 125 refers the number/index of the custom dimension.")]
	public class Dimension125: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension125" />.
		/// </summary>
		public Dimension125(): base("Custom Dimension 125",true,"ga:dimension125")
		{
			
		}
	}
}

