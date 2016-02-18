namespace DotNetAnalytics.Google.Metrics
{
	public class GoalCompletionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of completions for all goals defined for your profile.
		/// </summary>
		public GoalCompletionsMetric(): base("Goal Completions","The total number of completions for all goals defined for your profile.",true,"ga:goalCompletionsAll")
		{
			
		}
	}
}

