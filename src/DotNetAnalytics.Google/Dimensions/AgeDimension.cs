namespace DotNetAnalytics.Google.Dimensions
{
	public class AgeDimension: Dimension<string>
	{
		/// <summary>
		/// 	Age bracket of user.
		/// </summary>
		public AgeDimension(): base("Age","Age bracket of user.",false,"ga:userAgeBracket")
		{
			
		}
	}
}

