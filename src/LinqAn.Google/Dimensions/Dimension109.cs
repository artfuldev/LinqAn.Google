using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 109 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 109 refers the number/index of the custom dimension.")]
	public class Dimension109: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension109" />.
		/// </summary>
		public Dimension109(): base("Custom Dimension 109",true,"ga:dimension109")
		{
			
		}
	}
}

