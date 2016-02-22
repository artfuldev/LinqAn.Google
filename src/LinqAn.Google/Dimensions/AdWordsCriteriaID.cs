using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
	/// </summary>
	[Description("A string corresponding to the AdWords API Criterion.id. The geographical targeting Criteria IDs can be found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid")]
	public class AdwordsCriteriaId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdwordsCriteriaId" />.
		/// </summary>
		public AdwordsCriteriaId(): base("AdWords Criteria ID",false,"ga:adwordsCriteriaID")
		{
			
		}
	}
}

