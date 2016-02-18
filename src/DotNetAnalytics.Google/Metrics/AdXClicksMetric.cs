namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of times AdX ads were clicked on your site.
	/// </summary>
	public class AdXClicksMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdXClicksMetric" />.
		/// </summary>
		public AdXClicksMetric(): base("AdX Clicks","The number of times AdX ads were clicked on your site.",true,"ga:adxClicks")
		{
			
		}
	}
}

