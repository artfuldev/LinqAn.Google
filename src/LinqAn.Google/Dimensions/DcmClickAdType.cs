namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad type name of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickAdType: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickAdType" />.
		/// </summary>
		public DcmClickAdType(): base("DFA Ad Type (GA Model)","DCM ad type name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdType")
		{
			
		}
	}
}

