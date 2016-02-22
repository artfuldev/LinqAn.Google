using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units refunded (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of product units refunded (Enhanced Ecommerce).")]
	public class QuantityRefunded: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityRefunded" />.
		/// </summary>
		public QuantityRefunded(): base("Quantity Refunded",true,"ga:quantityRefunded")
		{
			
		}
	}
}

