using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 22 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 22 refers the number/index of the custom dimension.")]
	public class Dimension22: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension22" />.
		/// </summary>
		public Dimension22(): base("Custom Dimension 22",true,"ga:dimension22")
		{
			
		}
	}
}

