namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Age bracket of user.
	/// </summary>
	public class AgeDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AgeDimension" />.
		/// </summary>
		public AgeDimension(): base("Age","Age bracket of user.",false,"ga:userAgeBracket")
		{
			
		}
	}
}

