using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 120 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 120 refers the number/index of the custom dimension.")]
	public class Dimension120: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension120" />.
		/// </summary>
		public Dimension120(): base("Custom Dimension 120",true,"ga:dimension120")
		{
			
		}
	}
}

