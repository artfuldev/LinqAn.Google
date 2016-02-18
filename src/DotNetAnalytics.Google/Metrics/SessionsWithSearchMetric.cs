namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions that included an internal search
	/// </summary>
	public class SessionsWithSearchMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SessionsWithSearchMetric" />.
		/// </summary>
		public SessionsWithSearchMetric(): base("Sessions with Search","The total number of sessions that included an internal search",true,"ga:searchSessions")
		{
			
		}
	}
}

