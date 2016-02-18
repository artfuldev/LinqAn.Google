namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for all goals defined for your profile.
	/// </summary>
	public class GoalCompletionsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="GoalCompletionsMetric" />.
		/// </summary>
		public GoalCompletionsMetric(): base("Goal Completions","The total number of completions for all goals defined for your profile.",true,"ga:goalCompletionsAll")
		{
			
		}
	}
}

