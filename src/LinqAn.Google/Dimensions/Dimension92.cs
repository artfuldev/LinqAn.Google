using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 92 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 92 refers the number/index of the custom dimension.")]
	public class Dimension92: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension92" />.
		/// </summary>
		public Dimension92(): base("Custom Dimension 92",true,"ga:dimension92")
		{
			
		}
	}
}

