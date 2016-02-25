using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The value for the requested custom variable.
	/// </summary>
	[Description("The value for the requested custom variable.")]
	public class CustomVarValue1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CustomVarValue1" />.
		/// </summary>
		public CustomVarValue1(): base("Custom Variable (Value 1)",true,"ga:customVarValue1")
		{
			
		}
	}
}

