using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 123 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 123 refers the number/index of the custom dimension.")]
	public class Dimension123: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension123" />.
		/// </summary>
		public Dimension123(): base("Custom Dimension 123",true,"ga:dimension123")
		{
			
		}
	}
}

