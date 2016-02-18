namespace DotNetAnalytics.Google.Metrics
{
	public class ExceptionsMetric: Metric<int>
	{
		public ExceptionsMetric(): base("Exceptions","The number of exceptions that were sent to Google Analytics.",true,"ga:exceptions")
		{
			
		}
	}
}

