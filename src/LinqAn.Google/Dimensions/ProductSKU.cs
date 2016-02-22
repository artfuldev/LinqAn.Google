namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The product sku for purchased items as you have defined them in your ecommerce tracking application.
	/// </summary>
	public class ProductSku: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductSku" />.
		/// </summary>
		public ProductSku(): base("Product SKU","The product sku for purchased items as you have defined them in your ecommerce tracking application.",true,"ga:productSku")
		{
			
		}
	}
}

