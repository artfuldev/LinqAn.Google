using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 199 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 199 refers the number/index of the custom dimension.")]
	public class Dimension199: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension199" />.
		/// </summary>
		public Dimension199(): base("Custom Dimension 199",true,"ga:dimension199")
		{
			
		}
	}
}

