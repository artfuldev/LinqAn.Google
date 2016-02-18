namespace DotNetAnalytics.Google.Metrics
{
	public class AdXECPMMetric: Metric<decimal>
	{
		/// <summary>
		/// 	The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.
		/// </summary>
		public AdXECPMMetric(): base("AdX eCPM","The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.",false,"ga:adxECPM")
		{
			
		}
	}
}

