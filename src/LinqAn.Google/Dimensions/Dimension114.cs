using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 114 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 114 refers the number/index of the custom dimension.")]
	public class Dimension114: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension114" />.
		/// </summary>
		public Dimension114(): base("Custom Dimension 114",true,"ga:dimension114")
		{
			
		}
	}
}

