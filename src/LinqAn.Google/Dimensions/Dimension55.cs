using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 55 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 55 refers the number/index of the custom dimension.")]
	public class Dimension55: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension55" />.
		/// </summary>
		public Dimension55(): base("Custom Dimension 55",true,"ga:dimension55")
		{
			
		}
	}
}

