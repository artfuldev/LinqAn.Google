using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 175 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 175 refers the number/index of the custom dimension.")]
	public class Dimension175: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension175" />.
		/// </summary>
		public Dimension175(): base("Custom Dimension 175",true,"ga:dimension175")
		{
			
		}
	}
}

