using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 155 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 155 refers the number/index of the custom dimension.")]
	public class Dimension155: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension155" />.
		/// </summary>
		public Dimension155(): base("Custom Dimension 155",true,"ga:dimension155")
		{
			
		}
	}
}

