using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of product units included in check out (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of product units included in check out (Enhanced Ecommerce).")]
	public class QuantityCheckedOut: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QuantityCheckedOut" />.
		/// </summary>
		public QuantityCheckedOut(): base("Quantity Checked Out",true,"ga:quantityCheckedOut")
		{
			
		}
	}
}

