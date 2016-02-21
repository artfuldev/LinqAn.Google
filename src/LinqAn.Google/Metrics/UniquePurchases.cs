namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased.
	/// </summary>
	public class UniquePurchases: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UniquePurchases" />.
		/// </summary>
		public UniquePurchases(): base("Unique Purchases","The number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased.",true,"ga:uniquePurchases")
		{
			
		}
	}
}

