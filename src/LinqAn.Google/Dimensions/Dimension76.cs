using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 76 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 76 refers the number/index of the custom dimension.")]
	public class Dimension76: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension76" />.
		/// </summary>
		public Dimension76(): base("Custom Dimension 76",true,"ga:dimension76")
		{
			
		}
	}
}

