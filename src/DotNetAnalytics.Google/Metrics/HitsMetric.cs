namespace DotNetAnalytics.Google.Metrics
{
	public class HitsMetric: Metric<int>
	{
		public HitsMetric(): base("Hits","Total number of hits sent to Google Analytics, for the view (profile). This metric sums all hit types, including pageview, custom event, ecommerce, and other types. Note that this number is based on the view (profile), not the property, and therefore is not the same as the property's hit volume.",true,"ga:hits")
		{
			
		}
	}
}

