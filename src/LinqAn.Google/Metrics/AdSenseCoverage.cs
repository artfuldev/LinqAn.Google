namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of ad requests that returned at least one ad.
	/// </summary>
	public class AdsenseCoverage: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseCoverage" />.
		/// </summary>
		public AdsenseCoverage(): base("AdSense Coverage","The percentage of ad requests that returned at least one ad.",false,"ga:adsenseCoverage")
		{
			
		}
	}
}

