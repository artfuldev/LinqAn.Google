using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 200 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 200 refers the number/index of the custom dimension.")]
	public class Dimension200: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension200" />.
		/// </summary>
		public Dimension200(): base("Custom Dimension 200",true,"ga:dimension200")
		{
			
		}
	}
}

