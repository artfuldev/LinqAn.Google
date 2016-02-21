namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative type ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickCreativeTypeId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DcmClickCreativeTypeId" />.
		/// </summary>
		public DcmClickCreativeTypeId(): base("DFA Creative Type ID (GA Model)","DCM creative type ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreativeTypeId")
		{
			
		}
	}
}

