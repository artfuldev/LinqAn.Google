namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total revenue from AdSense ads.
	/// </summary>
	public class AdsenseRevenue: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdsenseRevenue" />.
		/// </summary>
		public AdsenseRevenue(): base("AdSense Revenue","The total revenue from AdSense ads.",true,"ga:adsenseRevenue")
		{
			
		}
	}
}

