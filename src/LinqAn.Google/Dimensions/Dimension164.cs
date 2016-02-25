using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 164 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 164 refers the number/index of the custom dimension.")]
	public class Dimension164: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension164" />.
		/// </summary>
		public Dimension164(): base("Custom Dimension 164",true,"ga:dimension164")
		{
			
		}
	}
}

