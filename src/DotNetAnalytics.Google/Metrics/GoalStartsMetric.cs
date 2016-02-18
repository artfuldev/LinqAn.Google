namespace DotNetAnalytics.Google.Metrics
{
	public class GoalStartsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of starts for all goals defined for your profile.
		/// </summary>
		public GoalStartsMetric(): base("Goal Starts","The total number of starts for all goals defined for your profile.",true,"ga:goalStartsAll")
		{
			
		}
	}
}

