using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Indicates that users are more likely to be ready to purchase products or services in the specified category.
	/// </summary>
	[Description("Indicates that users are more likely to be ready to purchase products or services in the specified category.")]
	public class InterestInMarketCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InterestInMarketCategory" />.
		/// </summary>
		public InterestInMarketCategory(): base("In-Market Segment",false,"ga:interestInMarketCategory")
		{
			
		}
	}
}

