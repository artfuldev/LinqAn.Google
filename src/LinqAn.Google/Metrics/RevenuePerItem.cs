using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average revenue per item.
	/// </summary>
	[Description("The average revenue per item.")]
	public class RevenuePerItem: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RevenuePerItem" />.
		/// </summary>
		public RevenuePerItem(): base("Average Price",false,"ga:revenuePerItem")
		{
			
		}
	}
}

