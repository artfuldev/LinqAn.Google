namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of single page (or single engagement hit) sessions for your property.
	/// </summary>
	public class BouncesMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="BouncesMetric" />.
		/// </summary>
		public BouncesMetric(): base("Bounces","The total number of single page (or single engagement hit) sessions for your property.",true,"ga:bounces")
		{
			
		}
	}
}

