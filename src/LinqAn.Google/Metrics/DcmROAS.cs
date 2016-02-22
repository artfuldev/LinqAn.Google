using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Return On Ad Spend (ROAS) (premium only).
	/// </summary>
	[Description("DCM Return On Ad Spend (ROAS) (premium only).")]
	public class DcmROAS: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmROAS" />.
		/// </summary>
		public DcmROAS(): base("DFA ROAS",false,"ga:dcmROAS")
		{
			
		}
	}
}

