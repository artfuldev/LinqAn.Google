namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickCreative: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmClickCreative" />.
		/// </summary>
		public DcmClickCreative(): base("DFA Creative (GA Model)","DCM creative name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreative")
		{
			
		}
	}
}

