using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of sessions that ended due to a user clicking on an AdSense ad.
	/// </summary>
	[Description("The number of sessions that ended due to a user clicking on an AdSense ad.")]
	public class AdsenseExits: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseExits" />.
		/// </summary>
		public AdsenseExits(): base("AdSense Exits",true,"ga:adsenseExits")
		{
			
		}
	}
}

