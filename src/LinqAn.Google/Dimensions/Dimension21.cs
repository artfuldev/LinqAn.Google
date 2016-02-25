using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 21 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 21 refers the number/index of the custom dimension.")]
	public class Dimension21: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension21" />.
		/// </summary>
		public Dimension21(): base("Custom Dimension 21",true,"ga:dimension21")
		{
			
		}
	}
}

