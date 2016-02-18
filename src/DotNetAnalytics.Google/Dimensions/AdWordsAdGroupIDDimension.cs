namespace DotNetAnalytics.Google.Dimensions
{
	public class AdWordsAdGroupIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	A string. Corresponds to AdWords API AdGroup.id.
		/// </summary>
		public AdWordsAdGroupIDDimension(): base("AdWords Ad Group ID","A string. Corresponds to AdWords API AdGroup.id.",false,"ga:adwordsAdGroupID")
		{
			
		}
	}
}

