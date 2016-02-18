namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API AccountInfo.customerId.
	/// </summary>
	public class AdWordsCustomerIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdWordsCustomerIDDimension" />.
		/// </summary>
		public AdWordsCustomerIDDimension(): base("AdWords Customer ID","A string. Corresponds to AdWords API AccountInfo.customerId.",false,"ga:adwordsCustomerID")
		{
			
		}
	}
}

