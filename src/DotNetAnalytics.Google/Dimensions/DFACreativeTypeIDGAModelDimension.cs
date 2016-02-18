namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACreativeTypeIDGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM creative type ID of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFACreativeTypeIDGAModelDimension(): base("DFA Creative Type ID (GA Model)","DCM creative type ID of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreativeTypeId")
		{
			
		}
	}
}

