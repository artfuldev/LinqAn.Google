using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 18 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 18 refers the number/index of the custom dimension.")]
	public class Dimension18: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension18" />.
		/// </summary>
		public Dimension18(): base("Custom Dimension 18",true,"ga:dimension18")
		{
			
		}
	}
}

