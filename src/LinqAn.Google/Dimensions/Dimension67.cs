using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 67 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 67 refers the number/index of the custom dimension.")]
	public class Dimension67: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension67" />.
		/// </summary>
		public Dimension67(): base("Custom Dimension 67",true,"ga:dimension67")
		{
			
		}
	}
}

