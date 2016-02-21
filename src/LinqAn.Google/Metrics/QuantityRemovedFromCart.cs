namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units removed from cart (Enhanced Ecommerce).
	/// </summary>
	public class QuantityRemovedFromCart: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityRemovedFromCart" />.
		/// </summary>
		public QuantityRemovedFromCart(): base("Quantity Removed From Cart","Number of product units removed from cart (Enhanced Ecommerce).",true,"ga:quantityRemovedFromCart")
		{
			
		}
	}
}

