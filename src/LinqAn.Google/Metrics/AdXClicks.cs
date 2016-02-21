namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times AdX ads were clicked on your site.
	/// </summary>
	public class AdxClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxClicks" />.
		/// </summary>
		public AdxClicks(): base("AdX Clicks","The number of times AdX ads were clicked on your site.",true,"ga:adxClicks")
		{
			
		}
	}
}

