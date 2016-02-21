namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.
	/// </summary>
	public class IsTrueViewVideoAd: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="IsTrueViewVideoAd" />.
		/// </summary>
		public IsTrueViewVideoAd(): base("TrueView Video Ad","Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.",false,"ga:isTrueViewVideoAd")
		{
			
		}
	}
}

