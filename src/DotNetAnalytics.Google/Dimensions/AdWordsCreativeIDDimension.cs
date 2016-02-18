namespace DotNetAnalytics.Google.Dimensions
{
	public class AdWordsCreativeIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	A string. Corresponds to AdWords API Ad.id.
		/// </summary>
		public AdWordsCreativeIDDimension(): base("AdWords Creative ID","A string. Corresponds to AdWords API Ad.id.",false,"ga:adwordsCreativeID")
		{
			
		}
	}
}

