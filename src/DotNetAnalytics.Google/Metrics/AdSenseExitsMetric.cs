namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseExitsMetric: Metric<int>
	{
		public AdSenseExitsMetric(): base("AdSense Exits","The number of sessions that ended due to a user clicking on an AdSense ad.",true,"ga:adsenseExits")
		{
			
		}
	}
}

