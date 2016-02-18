namespace DotNetAnalytics.Google.Metrics
{
	public class GoalStartsMetric: Metric<int>
	{
		public GoalStartsMetric(): base("Goal Starts","The total number of starts for all goals defined for your profile.",true,"ga:goalStartsAll")
		{
			
		}
	}
}

