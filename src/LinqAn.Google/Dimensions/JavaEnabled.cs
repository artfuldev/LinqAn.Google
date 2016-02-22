using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.
	/// </summary>
	[Description("Indicates Java support for users' browsers. The possible values are Yes or No where the first letter must be capitalized.")]
	public class JavaEnabled: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="JavaEnabled" />.
		/// </summary>
		public JavaEnabled(): base("Java Support",true,"ga:javaEnabled")
		{
			
		}
	}
}

