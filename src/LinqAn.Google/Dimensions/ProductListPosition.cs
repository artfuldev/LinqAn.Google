using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The position of the product in the product list (Enhanced Ecommerce).
	/// </summary>
	[Description("The position of the product in the product list (Enhanced Ecommerce).")]
	public class ProductListPosition: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductListPosition" />.
		/// </summary>
		public ProductListPosition(): base("Product List Position",true,"ga:productListPosition")
		{
			
		}
	}
}

