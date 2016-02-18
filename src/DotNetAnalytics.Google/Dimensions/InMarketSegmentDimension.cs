namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Indicates that users are more likely to be ready to purchase products or services in the specified category.
	/// </summary>
	public class InMarketSegmentDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="InMarketSegmentDimension" />.
		/// </summary>
		public InMarketSegmentDimension(): base("In-Market Segment","Indicates that users are more likely to be ready to purchase products or services in the specified category.",false,"ga:interestInMarketCategory")
		{
			
		}
	}
}

