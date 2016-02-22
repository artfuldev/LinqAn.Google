using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units removed from cart (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of product units removed from cart (Enhanced Ecommerce).")]
	public class QuantityRemovedFromCart: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityRemovedFromCart" />.
		/// </summary>
		public QuantityRemovedFromCart(): base("Quantity Removed From Cart",true,"ga:quantityRemovedFromCart")
		{
			
		}
	}
}

