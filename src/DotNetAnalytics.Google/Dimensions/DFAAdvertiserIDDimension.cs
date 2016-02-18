namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).
	/// </summary>
	public class DFAAdvertiserIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAAdvertiserIDDimension" />.
		/// </summary>
		public DFAAdvertiserIDDimension(): base("DFA Advertiser ID","DCM Floodlight advertiser ID associated with the floodlight conversion (premium only).",false,"ga:dcmFloodlightAdvertiserId")
		{
			
		}
	}
}

