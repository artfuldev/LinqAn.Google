using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 77 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 77 refers the number/index of the custom dimension.")]
	public class Dimension77: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension77" />.
		/// </summary>
		public Dimension77(): base("Custom Dimension 77",true,"ga:dimension77")
		{
			
		}
	}
}

