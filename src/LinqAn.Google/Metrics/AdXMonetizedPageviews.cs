using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your linked AdX account. Note - a single page can have multiple ad units.
	/// </summary>
	[Description("Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your linked AdX account. Note - a single page can have multiple ad units.")]
	public class AdxMonetizedPageviews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxMonetizedPageviews" />.
		/// </summary>
		public AdxMonetizedPageviews(): base("AdX Monetized Pageviews",true,"ga:adxMonetizedPageviews")
		{
			
		}
	}
}

