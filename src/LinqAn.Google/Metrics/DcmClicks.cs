using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Total Clicks (premium only).
	/// </summary>
	[Description("DCM Total Clicks (premium only).")]
	public class DcmClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClicks" />.
		/// </summary>
		public DcmClicks(): base("DFA Clicks",false,"ga:dcmClicks")
		{
			
		}
	}
}

