using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of page impressions that resulted in a click on an AdSense ad.
	/// </summary>
	[Description("The percentage of page impressions that resulted in a click on an AdSense ad.")]
	public class AdsenseCTR: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseCTR" />.
		/// </summary>
		public AdsenseCTR(): base("AdSense CTR",false,"ga:adsenseCTR")
		{
			
		}
	}
}

