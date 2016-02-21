namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of DCM Floodlight conversions (premium only).
	/// </summary>
	public class DcmFloodlightQuantity: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmFloodlightQuantity" />.
		/// </summary>
		public DcmFloodlightQuantity(): base("DFA Conversions","The number of DCM Floodlight conversions (premium only).",false,"ga:dcmFloodlightQuantity")
		{
			
		}
	}
}

