using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The value for the requested custom variable.
	/// </summary>
	[Description("The value for the requested custom variable.")]
	public class CustomVarValue2: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CustomVarValue2" />.
		/// </summary>
		public CustomVarValue2(): base("Custom Variable (Value 2)",true,"ga:customVarValue2")
		{
			
		}
	}
}

