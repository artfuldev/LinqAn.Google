using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Floodlight revenue (premium only).
	/// </summary>
	[Description("DCM Floodlight revenue (premium only).")]
	public class DcmFloodlightRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightRevenue" />.
		/// </summary>
		public DcmFloodlightRevenue(): base("DFA Revenue",false,"ga:dcmFloodlightRevenue")
		{
			
		}
	}
}

