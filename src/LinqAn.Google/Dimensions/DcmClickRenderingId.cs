namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM rendering ID of the DCM click matching the Google Analytics session (premium only).
	/// </summary>
	public class DcmClickRenderingId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmClickRenderingId" />.
		/// </summary>
		public DcmClickRenderingId(): base("DFA Rendering ID (GA Model)","DCM rendering ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickRenderingId")
		{
			
		}
	}
}

