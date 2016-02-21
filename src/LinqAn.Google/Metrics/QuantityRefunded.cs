namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units refunded (Enhanced Ecommerce).
	/// </summary>
	public class QuantityRefunded: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityRefunded" />.
		/// </summary>
		public QuantityRefunded(): base("Quantity Refunded","Number of product units refunded (Enhanced Ecommerce).",true,"ga:quantityRefunded")
		{
			
		}
	}
}

