using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 115 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 115 refers the number/index of the custom dimension.")]
	public class Dimension115: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension115" />.
		/// </summary>
		public Dimension115(): base("Custom Dimension 115",true,"ga:dimension115")
		{
			
		}
	}
}

