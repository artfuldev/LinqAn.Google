using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 139 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 139 refers the number/index of the custom dimension.")]
	public class Dimension139: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension139" />.
		/// </summary>
		public Dimension139(): base("Custom Dimension 139",true,"ga:dimension139")
		{
			
		}
	}
}

