namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of pageviews for your property.
	/// </summary>
	public class Pageviews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Pageviews" />.
		/// </summary>
		public Pageviews(): base("Pageviews","The total number of pageviews for your property.",true,"ga:pageviews")
		{
			
		}
	}
}

