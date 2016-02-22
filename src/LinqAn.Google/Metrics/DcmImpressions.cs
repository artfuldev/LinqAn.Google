using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Total Impressions (premium only).
	/// </summary>
	[Description("DCM Total Impressions (premium only).")]
	public class DcmImpressions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmImpressions" />.
		/// </summary>
		public DcmImpressions(): base("DFA Impressions",false,"ga:dcmImpressions")
		{
			
		}
	}
}

