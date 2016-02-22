using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The product name for purchased items as supplied by your ecommerce tracking application.
	/// </summary>
	[Description("The product name for purchased items as supplied by your ecommerce tracking application.")]
	public class ProductName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductName" />.
		/// </summary>
		public ProductName(): base("Product",true,"ga:productName")
		{
			
		}
	}
}

