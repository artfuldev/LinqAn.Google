namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times a refund was issued for the product (Enhanced Ecommerce).
	/// </summary>
	public class ProductRefunds: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductRefunds" />.
		/// </summary>
		public ProductRefunds(): base("Product Refunds","Number of times a refund was issued for the product (Enhanced Ecommerce).",true,"ga:productRefunds")
		{
			
		}
	}
}

