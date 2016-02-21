namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The sample set (or count) of pageviews used to calculate the average page load time.
	/// </summary>
	public class PageLoadSample: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageLoadSample" />.
		/// </summary>
		public PageLoadSample(): base("Page Load Sample","The sample set (or count) of pageviews used to calculate the average page load time.",false,"ga:pageLoadSample")
		{
			
		}
	}
}

