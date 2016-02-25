using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 144 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 144 refers the number/index of the custom dimension.")]
	public class Dimension144: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension144" />.
		/// </summary>
		public Dimension144(): base("Custom Dimension 144",true,"ga:dimension144")
		{
			
		}
	}
}

