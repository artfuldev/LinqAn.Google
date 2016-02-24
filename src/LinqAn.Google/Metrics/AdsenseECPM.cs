using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The estimated cost per thousand page impressions. It is your AdSense Revenue per 1000 page impressions.
	/// </summary>
	[Description("The estimated cost per thousand page impressions. It is your AdSense Revenue per 1000 page impressions.")]
	public class AdsenseECPM: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseECPM" />.
		/// </summary>
		public AdsenseECPM(): base("AdSense eCPM",false,"ga:adsenseECPM")
		{
			
		}
	}
}

