using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of DCM Floodlight conversions (premium only).
	/// </summary>
	[Description("The number of DCM Floodlight conversions (premium only).")]
	public class DcmFloodlightQuantity: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightQuantity" />.
		/// </summary>
		public DcmFloodlightQuantity(): base("DFA Conversions",false,"ga:dcmFloodlightQuantity")
		{
			
		}
	}
}

