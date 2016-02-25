using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 57 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 57 refers the number/index of the custom dimension.")]
	public class Dimension57: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension57" />.
		/// </summary>
		public Dimension57(): base("Custom Dimension 57",true,"ga:dimension57")
		{
			
		}
	}
}

