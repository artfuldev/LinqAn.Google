using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM ad type ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM ad type ID of the DCM click matching the Google Analytics session (premium only).")]
	public class DcmClickAdTypeId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickAdTypeId" />.
		/// </summary>
		public DcmClickAdTypeId(): base("DFA Ad Type ID",false,"ga:dcmClickAdTypeId")
		{
			
		}
	}
}

