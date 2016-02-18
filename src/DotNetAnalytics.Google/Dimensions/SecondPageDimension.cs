namespace DotNetAnalytics.Google.Dimensions
{
	public class SecondPageDimension: Dimension<string>
	{
		/// <summary>
		/// 	The second page in a user's session.
		/// </summary>
		public SecondPageDimension(): base("Second Page","The second page in a user's session.",false,"ga:secondPagePath")
		{
			
		}
	}
}

