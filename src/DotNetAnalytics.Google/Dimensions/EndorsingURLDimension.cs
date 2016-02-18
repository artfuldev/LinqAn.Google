namespace DotNetAnalytics.Google.Dimensions
{
	public class EndorsingURLDimension: Dimension<string>
	{
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)
		/// </summary>
		public EndorsingURLDimension(): base("Endorsing URL","For a social data hub activity, this value represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)",false,"ga:socialActivityEndorsingUrl")
		{
			
		}
	}
}

