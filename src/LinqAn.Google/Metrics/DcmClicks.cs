namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Total Clicks (premium only).
	/// </summary>
	public class DcmClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClicks" />.
		/// </summary>
		public DcmClicks(): base("DFA Clicks","DCM Total Clicks (premium only).",false,"ga:dcmClicks")
		{
			
		}
	}
}

