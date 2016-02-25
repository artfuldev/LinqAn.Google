using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 112 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 112 refers the number/index of the custom dimension.")]
	public class Dimension112: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension112" />.
		/// </summary>
		public Dimension112(): base("Custom Dimension 112",true,"ga:dimension112")
		{
			
		}
	}
}

