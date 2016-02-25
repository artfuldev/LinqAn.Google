using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The value for the requested custom variable.
	/// </summary>
	[Description("The value for the requested custom variable.")]
	public class CustomVarValue32: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CustomVarValue32" />.
		/// </summary>
		public CustomVarValue32(): base("Custom Variable (Value 32)",true,"ga:customVarValue32")
		{
			
		}
	}
}

