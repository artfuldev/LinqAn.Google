namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The product name for purchased items as supplied by your ecommerce tracking application.
	/// </summary>
	public class ProductName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductName" />.
		/// </summary>
		public ProductName(): base("Product","The product name for purchased items as supplied by your ecommerce tracking application.",true,"ga:productName")
		{
			
		}
	}
}

