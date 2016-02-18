namespace DotNetAnalytics.Google.Metrics
{
	public class AdXCTRMetric: Metric<float>
	{
		/// <summary>
		/// 	The percentage of pageviews that resulted in a click on an AdX ad.
		/// </summary>
		public AdXCTRMetric(): base("AdX CTR","The percentage of pageviews that resulted in a click on an AdX ad.",false,"ga:adxCTR")
		{
			
		}
	}
}

