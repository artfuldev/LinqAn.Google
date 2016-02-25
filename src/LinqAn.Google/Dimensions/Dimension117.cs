using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 117 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 117 refers the number/index of the custom dimension.")]
	public class Dimension117: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension117" />.
		/// </summary>
		public Dimension117(): base("Custom Dimension 117",true,"ga:dimension117")
		{
			
		}
	}
}

