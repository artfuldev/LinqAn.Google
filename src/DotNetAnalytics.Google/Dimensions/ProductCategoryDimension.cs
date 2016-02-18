namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce.
	/// </summary>
	public class ProductCategoryDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductCategoryDimension" />.
		/// </summary>
		public ProductCategoryDimension(): base("Product Category","Any product variations (size, color) for purchased items as supplied by your ecommerce application. Not compatible with Enhanced Ecommerce.",true,"ga:productCategory")
		{
			
		}
	}
}

