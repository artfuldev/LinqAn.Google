using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units added to the shopping cart (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of product units added to the shopping cart (Enhanced Ecommerce).")]
	public class QuantityAddedToCart: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityAddedToCart" />.
		/// </summary>
		public QuantityAddedToCart(): base("Quantity Added To Cart",true,"ga:quantityAddedToCart")
		{
			
		}
	}
}

