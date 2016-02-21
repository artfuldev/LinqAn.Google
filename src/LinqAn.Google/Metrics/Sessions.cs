namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions.
	/// </summary>
	public class Sessions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Sessions" />.
		/// </summary>
		public Sessions(): base("Sessions","The total number of sessions.",true,"ga:sessions")
		{
			
		}
	}
}

