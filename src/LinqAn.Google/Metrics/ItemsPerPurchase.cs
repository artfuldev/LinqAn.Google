using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average quantity of this item (or group of items) sold per purchase.
	/// </summary>
	[Description("The average quantity of this item (or group of items) sold per purchase.")]
	public class ItemsPerPurchase: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ItemsPerPurchase" />.
		/// </summary>
		public ItemsPerPurchase(): base("Average QTY",false,"ga:itemsPerPurchase")
		{
			
		}
	}
}

