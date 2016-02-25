using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 42 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 42 refers the number/index of the custom dimension.")]
	public class Dimension42: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension42" />.
		/// </summary>
		public Dimension42(): base("Custom Dimension 42",true,"ga:dimension42")
		{
			
		}
	}
}

