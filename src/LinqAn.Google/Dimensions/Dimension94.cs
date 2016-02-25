using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 94 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 94 refers the number/index of the custom dimension.")]
	public class Dimension94: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension94" />.
		/// </summary>
		public Dimension94(): base("Custom Dimension 94",true,"ga:dimension94")
		{
			
		}
	}
}

