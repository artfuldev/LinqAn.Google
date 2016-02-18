namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseCoverageMetric: Metric<float>
	{
		public AdSenseCoverageMetric(): base("AdSense Coverage","The percentage of ad requests that returned at least one ad.",false,"ga:adsenseCoverage")
		{
			
		}
	}
}

