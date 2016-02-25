using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 161 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 161 refers the number/index of the custom dimension.")]
	public class Dimension161: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension161" />.
		/// </summary>
		public Dimension161(): base("Custom Dimension 161",true,"ga:dimension161")
		{
			
		}
	}
}

