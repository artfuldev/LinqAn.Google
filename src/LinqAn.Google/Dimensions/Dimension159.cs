using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 159 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 159 refers the number/index of the custom dimension.")]
	public class Dimension159: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension159" />.
		/// </summary>
		public Dimension159(): base("Custom Dimension 159",true,"ga:dimension159")
		{
			
		}
	}
}

