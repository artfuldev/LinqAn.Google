using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 105 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 105 refers the number/index of the custom dimension.")]
	public class Dimension105: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension105" />.
		/// </summary>
		public Dimension105(): base("Custom Dimension 105",true,"ga:dimension105")
		{
			
		}
	}
}

