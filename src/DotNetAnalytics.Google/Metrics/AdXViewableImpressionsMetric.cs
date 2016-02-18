namespace DotNetAnalytics.Google.Metrics
{
	public class AdXViewableImpressionsMetric: Metric<float>
	{
		public AdXViewableImpressionsMetric(): base("AdX Viewable Impressions %","The percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen.",false,"ga:adxViewableImpressionsPercent")
		{
			
		}
	}
}

