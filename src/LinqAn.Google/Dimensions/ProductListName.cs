using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the product list in which the product appears (Enhanced Ecommerce).
	/// </summary>
	[Description("The name of the product list in which the product appears (Enhanced Ecommerce).")]
	public class ProductListName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductListName" />.
		/// </summary>
		public ProductListName(): base("Product List Name",true,"ga:productListName")
		{
			
		}
	}
}

