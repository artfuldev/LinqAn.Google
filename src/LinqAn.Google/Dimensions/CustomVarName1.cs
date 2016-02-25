using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name for the requested custom variable.
	/// </summary>
	[Description("The name for the requested custom variable.")]
	public class CustomVarName1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CustomVarName1" />.
		/// </summary>
		public CustomVarName1(): base("Custom Variable (Key 1)",true,"ga:customVarName1")
		{
			
		}
	}
}

