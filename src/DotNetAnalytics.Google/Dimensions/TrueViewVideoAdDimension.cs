namespace DotNetAnalytics.Google.Dimensions
{
	public class TrueViewVideoAdDimension: Dimension<string>
	{
		/// <summary>
		/// 	Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.
		/// </summary>
		public TrueViewVideoAdDimension(): base("TrueView Video Ad","Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.",false,"ga:isTrueViewVideoAd")
		{
			
		}
	}
}

