namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickSite: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmClickSite" />.
		/// </summary>
		public DcmClickSite(): base("DFA Site (GA Model)","Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickSite")
		{
			
		}
	}
}

