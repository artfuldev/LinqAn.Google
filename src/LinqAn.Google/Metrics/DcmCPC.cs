using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Cost Per Click (premium only).
	/// </summary>
	[Description("DCM Cost Per Click (premium only).")]
	public class DcmCPC: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmCPC" />.
		/// </summary>
		public DcmCPC(): base("DFA CPC",false,"ga:dcmCPC")
		{
			
		}
	}
}

