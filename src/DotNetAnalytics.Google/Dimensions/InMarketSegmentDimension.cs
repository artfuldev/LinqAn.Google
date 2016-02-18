namespace DotNetAnalytics.Google.Dimensions
{
	public class InMarketSegmentDimension: Dimension<string>
	{
		/// <summary>
		/// 	Indicates that users are more likely to be ready to purchase products or services in the specified category.
		/// </summary>
		public InMarketSegmentDimension(): base("In-Market Segment","Indicates that users are more likely to be ready to purchase products or services in the specified category.",false,"ga:interestInMarketCategory")
		{
			
		}
	}
}

