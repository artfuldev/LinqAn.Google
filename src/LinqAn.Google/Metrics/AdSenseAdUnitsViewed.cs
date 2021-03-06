using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en
	/// </summary>
	[Description("The number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en")]
	public class AdsenseAdUnitsViewed: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseAdUnitsViewed" />.
		/// </summary>
		public AdsenseAdUnitsViewed(): base("AdSense Ad Units Viewed",true,"ga:adsenseAdUnitsViewed")
		{
			
		}
	}
}

