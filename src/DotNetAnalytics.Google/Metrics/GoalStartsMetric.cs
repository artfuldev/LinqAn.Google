namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for all goals defined for your profile.
	/// </summary>
	public class GoalStartsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="GoalStartsMetric" />.
		/// </summary>
		public GoalStartsMetric(): base("Goal Starts","The total number of starts for all goals defined for your profile.",true,"ga:goalStartsAll")
		{
			
		}
	}
}

