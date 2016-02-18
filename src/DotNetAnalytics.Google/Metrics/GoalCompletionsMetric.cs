namespace DotNetAnalytics.Google.Metrics
{
	public class GoalCompletionsMetric: Metric<int>
	{
		public GoalCompletionsMetric(): base("Goal Completions","The total number of completions for all goals defined for your profile.",true,"ga:goalCompletionsAll")
		{
			
		}
	}
}

