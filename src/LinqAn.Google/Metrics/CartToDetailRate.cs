using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Product adds divided by views of product details (Enhanced Ecommerce).
	/// </summary>
	[Description("Product adds divided by views of product details (Enhanced Ecommerce).")]
	public class CartToDetailRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CartToDetailRate" />.
		/// </summary>
		public CartToDetailRate(): base("Cart-to-Detail Rate",false,"ga:cartToDetailRate")
		{
			
		}
	}
}

