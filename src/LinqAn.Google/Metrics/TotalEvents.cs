namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of events for the profile, across all categories.
	/// </summary>
	public class TotalEvents: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TotalEvents" />.
		/// </summary>
		public TotalEvents(): base("Total Events","The total number of events for the profile, across all categories.",true,"ga:totalEvents")
		{
			
		}
	}
}

