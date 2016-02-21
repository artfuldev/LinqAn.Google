namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions that included an internal search
	/// </summary>
	public class SearchSessions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchSessions" />.
		/// </summary>
		public SearchSessions(): base("Sessions with Search","The total number of sessions that included an internal search",true,"ga:searchSessions")
		{
			
		}
	}
}

