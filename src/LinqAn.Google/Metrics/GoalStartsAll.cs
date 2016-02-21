namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for all goals defined for your profile.
	/// </summary>
	public class GoalStartsAll: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalStartsAll" />.
		/// </summary>
		public GoalStartsAll(): base("Goal Starts","The total number of starts for all goals defined for your profile.",true,"ga:goalStartsAll")
		{
			
		}
	}
}

