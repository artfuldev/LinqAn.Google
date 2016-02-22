namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of pages visited by users during a session. The value is a histogram that counts pageviews across a range of possible values. In this calculation, all sessions will have at least one pageview, and some percentage of sessions will have more.
	/// </summary>
	public class PageDepth: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageDepth" />.
		/// </summary>
		public PageDepth(): base("Page Depth","The number of pages visited by users during a session. The value is a histogram that counts pageviews across a range of possible values. In this calculation, all sessions will have at least one pageview, and some percentage of sessions will have more.",true,"ga:pageDepth")
		{
			
		}
	}
}

