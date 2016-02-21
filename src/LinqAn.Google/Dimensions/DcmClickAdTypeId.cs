namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad type ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickAdTypeId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmClickAdTypeId" />.
		/// </summary>
		public DcmClickAdTypeId(): base("DFA Ad Type ID","DCM ad type ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickAdTypeId")
		{
			
		}
	}
}

