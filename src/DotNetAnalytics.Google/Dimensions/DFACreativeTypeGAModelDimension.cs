namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACreativeTypeGAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM creative type name of the DCM click matching the Google Analytics session (premium only).
		/// </summary>
		public DFACreativeTypeGAModelDimension(): base("DFA Creative Type (GA Model)","DCM creative type name of the DCM click matching the Google Analytics session (premium only).",false,"ga:dcmClickCreativeType")
		{
			
		}
	}
}

