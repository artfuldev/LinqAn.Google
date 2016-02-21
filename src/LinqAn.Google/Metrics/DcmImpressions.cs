namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Total Impressions (premium only).
	/// </summary>
	public class DcmImpressions: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmImpressions" />.
		/// </summary>
		public DcmImpressions(): base("DFA Impressions","DCM Total Impressions (premium only).",false,"ga:dcmImpressions")
		{
			
		}
	}
}

