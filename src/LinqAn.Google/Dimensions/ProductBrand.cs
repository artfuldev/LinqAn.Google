using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The brand name under which the product is sold (Enhanced Ecommerce).
	/// </summary>
	[Description("The brand name under which the product is sold (Enhanced Ecommerce).")]
	public class ProductBrand: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductBrand" />.
		/// </summary>
		public ProductBrand(): base("Product Brand",true,"ga:productBrand")
		{
			
		}
	}
}

