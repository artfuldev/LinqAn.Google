namespace DotNetAnalytics.Google.Metrics
{
	public class UserTimingSampleMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
		/// </summary>
		public UserTimingSampleMetric(): base("User Timing Sample","The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.",false,"ga:userTimingSample")
		{
			
		}
	}
}

