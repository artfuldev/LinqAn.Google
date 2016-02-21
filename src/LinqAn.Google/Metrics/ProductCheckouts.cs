namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product was included in the check-out process (Enhanced Ecommerce).
	/// </summary>
	public class ProductCheckouts: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductCheckouts" />.
		/// </summary>
		public ProductCheckouts(): base("Product Checkouts","Number of times the product was included in the check-out process (Enhanced Ecommerce).",true,"ga:productCheckouts")
		{
			
		}
	}
}

