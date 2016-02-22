using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.
	/// </summary>
	[Description("Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.")]
	public class IsTrueViewVideoAd: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="IsTrueViewVideoAd" />.
		/// </summary>
		public IsTrueViewVideoAd(): base("TrueView Video Ad",false,"ga:isTrueViewVideoAd")
		{
			
		}
	}
}

