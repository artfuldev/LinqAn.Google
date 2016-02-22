using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total estimated revenue from AdX ads.
	/// </summary>
	[Description("The total estimated revenue from AdX ads.")]
	public class AdxRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxRevenue" />.
		/// </summary>
		public AdxRevenue(): base("AdX Revenue",true,"ga:adxRevenue")
		{
			
		}
	}
}

