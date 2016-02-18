namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of exceptions that were sent to Google Analytics.
	/// </summary>
	public class ExceptionsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ExceptionsMetric" />.
		/// </summary>
		public ExceptionsMetric(): base("Exceptions","The number of exceptions that were sent to Google Analytics.",true,"ga:exceptions")
		{
			
		}
	}
}

