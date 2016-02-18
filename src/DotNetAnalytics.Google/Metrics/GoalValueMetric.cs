namespace DotNetAnalytics.Google.Metrics
{
	public class GoalValueMetric: Metric<decimal>
	{
		/// <summary>
		/// 	The total numeric value for all goals defined for your profile.
		/// </summary>
		public GoalValueMetric(): base("Goal Value","The total numeric value for all goals defined for your profile.",true,"ga:goalValueAll")
		{
			
		}
	}
}

