namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units added to the shopping cart (Enhanced Ecommerce).
	/// </summary>
	public class QuantityAddedToCart: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityAddedToCart" />.
		/// </summary>
		public QuantityAddedToCart(): base("Quantity Added To Cart","Number of product units added to the shopping cart (Enhanced Ecommerce).",true,"ga:quantityAddedToCart")
		{
			
		}
	}
}

