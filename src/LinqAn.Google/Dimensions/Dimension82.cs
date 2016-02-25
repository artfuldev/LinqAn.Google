using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 82 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 82 refers the number/index of the custom dimension.")]
	public class Dimension82: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension82" />.
		/// </summary>
		public Dimension82(): base("Custom Dimension 82",true,"ga:dimension82")
		{
			
		}
	}
}

