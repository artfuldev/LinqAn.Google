using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 62 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 62 refers the number/index of the custom dimension.")]
	public class Dimension62: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension62" />.
		/// </summary>
		public Dimension62(): base("Custom Dimension 62",true,"ga:dimension62")
		{
			
		}
	}
}

