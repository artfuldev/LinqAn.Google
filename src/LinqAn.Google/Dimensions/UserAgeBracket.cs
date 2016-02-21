namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Age bracket of user.
	/// </summary>
	public class UserAgeBracket: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserAgeBracket" />.
		/// </summary>
		public UserAgeBracket(): base("Age","Age bracket of user.",false,"ga:userAgeBracket")
		{
			
		}
	}
}

