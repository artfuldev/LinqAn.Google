namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API AccountInfo.customerId.
	/// </summary>
	public class AdwordsCustomerId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdwordsCustomerId" />.
		/// </summary>
		public AdwordsCustomerId(): base("AdWords Customer ID","A string. Corresponds to AdWords API AccountInfo.customerId.",false,"ga:adwordsCustomerID")
		{
			
		}
	}
}

