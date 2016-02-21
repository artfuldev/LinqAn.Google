namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
	/// </summary>
	public class UserTimingSample: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingSample" />.
		/// </summary>
		public UserTimingSample(): base("User Timing Sample","The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.",false,"ga:userTimingSample")
		{
			
		}
	}
}

