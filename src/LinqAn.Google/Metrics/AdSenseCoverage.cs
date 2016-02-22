using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of ad requests that returned at least one ad.
	/// </summary>
	[Description("The percentage of ad requests that returned at least one ad.")]
	public class AdsenseCoverage: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseCoverage" />.
		/// </summary>
		public AdsenseCoverage(): base("AdSense Coverage",false,"ga:adsenseCoverage")
		{
			
		}
	}
}

