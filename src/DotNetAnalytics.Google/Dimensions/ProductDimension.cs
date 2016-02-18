namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductDimension: Dimension<string>
	{
		/// <summary>
		/// 	The product name for purchased items as supplied by your ecommerce tracking application.
		/// </summary>
		public ProductDimension(): base("Product","The product name for purchased items as supplied by your ecommerce tracking application.",true,"ga:productName")
		{
			
		}
	}
}

