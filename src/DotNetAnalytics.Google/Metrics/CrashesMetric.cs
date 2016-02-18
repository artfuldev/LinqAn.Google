namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of exceptions where isFatal is set to true.
	/// </summary>
	public class CrashesMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="CrashesMetric" />.
		/// </summary>
		public CrashesMetric(): base("Crashes","The number of exceptions where isFatal is set to true.",true,"ga:fatalExceptions")
		{
			
		}
	}
}

