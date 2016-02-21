namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for all goals defined for your profile.
	/// </summary>
	public class GoalValueAll: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="GoalValueAll" />.
		/// </summary>
		public GoalValueAll(): base("Goal Value","The total numeric value for all goals defined for your profile.",true,"ga:goalValueAll")
		{
			
		}
	}
}

