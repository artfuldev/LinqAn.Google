using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 121 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 121 refers the number/index of the custom dimension.")]
	public class Dimension121: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension121" />.
		/// </summary>
		public Dimension121(): base("Custom Dimension 121",true,"ga:dimension121")
		{
			
		}
	}
}

