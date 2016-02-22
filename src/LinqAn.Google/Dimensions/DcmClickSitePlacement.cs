namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM site placement name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickSitePlacement: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickSitePlacement" />.
		/// </summary>
		public DcmClickSitePlacement(): base("DFA Placement (GA Model)","DCM site placement name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickSitePlacement")
		{
			
		}
	}
}

