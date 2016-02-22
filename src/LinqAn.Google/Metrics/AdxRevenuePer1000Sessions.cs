using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions.
	/// </summary>
	[Description("The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions.")]
	public class AdxRevenuePer1000Sessions: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxRevenuePer1000Sessions" />.
		/// </summary>
		public AdxRevenuePer1000Sessions(): base("AdX Revenue / 1000 Sessions",false,"ga:adxRevenuePer1000Sessions")
		{
			
		}
	}
}

