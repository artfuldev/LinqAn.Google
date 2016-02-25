using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 27 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 27 refers the number/index of the custom dimension.")]
	public class Dimension27: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension27" />.
		/// </summary>
		public Dimension27(): base("Custom Dimension 27",true,"ga:dimension27")
		{
			
		}
	}
}

