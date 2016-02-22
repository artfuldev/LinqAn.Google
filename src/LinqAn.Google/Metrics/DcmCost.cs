using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	DCM Total Cost (premium only).
	/// </summary>
	[Description("DCM Total Cost (premium only).")]
	public class DcmCost: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmCost" />.
		/// </summary>
		public DcmCost(): base("DFA Cost",false,"ga:dcmCost")
		{
			
		}
	}
}

