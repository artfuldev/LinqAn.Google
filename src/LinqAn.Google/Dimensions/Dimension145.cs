using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 145 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 145 refers the number/index of the custom dimension.")]
	public class Dimension145: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension145" />.
		/// </summary>
		public Dimension145(): base("Custom Dimension 145",true,"ga:dimension145")
		{
			
		}
	}
}

