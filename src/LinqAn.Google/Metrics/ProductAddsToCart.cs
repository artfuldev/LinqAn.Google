using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product was added to the shopping cart (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of times the product was added to the shopping cart (Enhanced Ecommerce).")]
	public class ProductAddsToCart: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductAddsToCart" />.
		/// </summary>
		public ProductAddsToCart(): base("Product Adds To Cart",true,"ga:productAddsToCart")
		{
			
		}
	}
}

