namespace DotNetAnalytics.Google.Metrics
{
	public class ExceptionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of exceptions that were sent to Google Analytics.
		/// </summary>
		public ExceptionsMetric(): base("Exceptions","The number of exceptions that were sent to Google Analytics.",true,"ga:exceptions")
		{
			
		}
	}
}

