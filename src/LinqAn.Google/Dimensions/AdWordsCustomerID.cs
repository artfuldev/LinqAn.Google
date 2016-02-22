using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API AccountInfo.customerId.
	/// </summary>
	[Description("A string. Corresponds to AdWords API AccountInfo.customerId.")]
	public class AdwordsCustomerId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdwordsCustomerId" />.
		/// </summary>
		public AdwordsCustomerId(): base("AdWords Customer ID",false,"ga:adwordsCustomerID")
		{
			
		}
	}
}

