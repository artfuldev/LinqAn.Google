namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialTagsSummaryDimension: Dimension<string>
	{
		/// <summary>
		/// 	For a social data hub activity, this is a comma-separated set of tags associated with the social activity.
		/// </summary>
		public SocialTagsSummaryDimension(): base("Social Tags Summary","For a social data hub activity, this is a comma-separated set of tags associated with the social activity.",false,"ga:socialActivityTagsSummary")
		{
			
		}
	}
}

