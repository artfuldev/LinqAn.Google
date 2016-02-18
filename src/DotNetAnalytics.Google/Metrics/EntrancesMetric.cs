namespace DotNetAnalytics.Google.Metrics
{
	public class EntrancesMetric: Metric<int>
	{
		public EntrancesMetric(): base("Entrances","The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath",true,"ga:entrances")
		{
			
		}
	}
}

