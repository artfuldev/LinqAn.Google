using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total revenue from purchased product items.
	/// </summary>
	[Description("The total revenue from purchased product items.")]
	public class ItemRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ItemRevenue" />.
		/// </summary>
		public ItemRevenue(): base("Product Revenue",true,"ga:itemRevenue")
		{
			
		}
	}
}

