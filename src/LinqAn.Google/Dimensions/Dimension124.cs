using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 124 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 124 refers the number/index of the custom dimension.")]
	public class Dimension124: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension124" />.
		/// </summary>
		public Dimension124(): base("Custom Dimension 124",true,"ga:dimension124")
		{
			
		}
	}
}

