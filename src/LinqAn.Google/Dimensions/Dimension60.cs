using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 60 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 60 refers the number/index of the custom dimension.")]
	public class Dimension60: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension60" />.
		/// </summary>
		public Dimension60(): base("Custom Dimension 60",true,"ga:dimension60")
		{
			
		}
	}
}

