using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Age bracket of user.
	/// </summary>
	[Description("Age bracket of user.")]
	public class UserAgeBracket: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserAgeBracket" />.
		/// </summary>
		public UserAgeBracket(): base("Age",false,"ga:userAgeBracket")
		{
			
		}
	}
}

