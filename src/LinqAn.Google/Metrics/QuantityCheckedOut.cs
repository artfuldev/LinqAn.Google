namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units included in check out (Enhanced Ecommerce).
	/// </summary>
	public class QuantityCheckedOut: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityCheckedOut" />.
		/// </summary>
		public QuantityCheckedOut(): base("Quantity Checked Out","Number of product units included in check out (Enhanced Ecommerce).",true,"ga:quantityCheckedOut")
		{
			
		}
	}
}

