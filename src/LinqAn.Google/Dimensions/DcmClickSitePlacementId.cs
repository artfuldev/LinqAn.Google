namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickSitePlacementId: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickSitePlacementId" />.
		/// </summary>
		public DcmClickSitePlacementId(): base("DFA Placement ID (GA Model)","DCM site placement ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickSitePlacementId")
		{
			
		}
	}
}

