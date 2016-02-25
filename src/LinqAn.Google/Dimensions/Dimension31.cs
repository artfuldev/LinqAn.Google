using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 31 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 31 refers the number/index of the custom dimension.")]
	public class Dimension31: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension31" />.
		/// </summary>
		public Dimension31(): base("Custom Dimension 31",true,"ga:dimension31")
		{
			
		}
	}
}

