namespace DotNetAnalytics.Google.Metrics
{
	public class CrashesMetric: Metric<int>
	{
		public CrashesMetric(): base("Crashes","The number of exceptions where isFatal is set to true.",true,"ga:fatalExceptions")
		{
			
		}
	}
}

