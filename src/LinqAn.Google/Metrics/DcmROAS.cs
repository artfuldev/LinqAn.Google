namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Return On Ad Spend (ROAS) (premium only).
	/// </summary>
	public class DcmROAS: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmROAS" />.
		/// </summary>
		public DcmROAS(): base("DFA ROAS","DCM Return On Ad Spend (ROAS) (premium only).",false,"ga:dcmROAS")
		{
			
		}
	}
}

