using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 183 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 183 refers the number/index of the custom dimension.")]
	public class Dimension183: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension183" />.
		/// </summary>
		public Dimension183(): base("Custom Dimension 183",true,"ga:dimension183")
		{
			
		}
	}
}

