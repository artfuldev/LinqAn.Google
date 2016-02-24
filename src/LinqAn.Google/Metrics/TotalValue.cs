using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total value for your property (including total revenue and total goal value).
	/// </summary>
	[Description("Total value for your property (including total revenue and total goal value).")]
	public class TotalValue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TotalValue" />.
		/// </summary>
		public TotalValue(): base("Total Value",false,"ga:totalValue")
		{
			
		}
	}
}

