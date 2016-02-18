namespace DotNetAnalytics.Google.Dimensions
{
	public class DFACreativeTypeIDDFAModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
		/// </summary>
		public DFACreativeTypeIDDFAModelDimension(): base("DFA Creative Type ID (DFA Model)","DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",false,"ga:dcmLastEventCreativeTypeId")
		{
			
		}
	}
}

