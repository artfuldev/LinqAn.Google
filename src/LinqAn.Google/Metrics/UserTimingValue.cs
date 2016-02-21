namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of milliseconds for a user timing.
	/// </summary>
	public class UserTimingValue: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UserTimingValue" />.
		/// </summary>
		public UserTimingValue(): base("User Timing (ms)","The total number of milliseconds for a user timing.",false,"ga:userTimingValue")
		{
			
		}
	}
}

