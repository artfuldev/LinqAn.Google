namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductSKUDimension: Dimension<string>
	{
		/// <summary>
		/// 	The product sku for purchased items as you have defined them in your ecommerce tracking application.
		/// </summary>
		public ProductSKUDimension(): base("Product SKU","The product sku for purchased items as you have defined them in your ecommerce tracking application.",true,"ga:productSku")
		{
			
		}
	}
}

