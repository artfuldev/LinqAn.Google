namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce.
	/// </summary>
	public class ProductCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCategory" />.
		/// </summary>
		public ProductCategory(): base("Product Category","Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce.",true,"ga:productCategory")
		{
			
		}
	}
}

