namespace DotNetAnalytics.Google.Dimensions
{
	public class AdWordsCriteriaIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		public AdWordsCriteriaIDDimension(): base("AdWords Criteria ID","A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid",false,"ga:adwordsCriteriaID")
		{
			
		}
	}
}

