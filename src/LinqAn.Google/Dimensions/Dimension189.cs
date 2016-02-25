using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 189 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 189 refers the number/index of the custom dimension.")]
	public class Dimension189: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension189" />.
		/// </summary>
		public Dimension189(): base("Custom Dimension 189",true,"ga:dimension189")
		{
			
		}
	}
}

