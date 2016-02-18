namespace DotNetAnalytics.Google.Dimensions
{
	public class AdWordsCustomerIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	A string. Corresponds to AdWords API AccountInfo.customerId.
		/// </summary>
		public AdWordsCustomerIDDimension(): base("AdWords Customer ID","A string. Corresponds to AdWords API AccountInfo.customerId.",false,"ga:adwordsCustomerID")
		{
			
		}
	}
}

