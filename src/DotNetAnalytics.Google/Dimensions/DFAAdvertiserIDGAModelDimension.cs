namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DFAAdvertiserIDGAModelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DFAAdvertiserIDGAModelDimension" />.
		/// </summary>
		public DFAAdvertiserIDGAModelDimension(): base("DFA Advertiser ID (GA Model)","DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdvertiserId")
		{
			
		}
	}
}

