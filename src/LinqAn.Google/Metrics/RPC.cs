using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.
	/// </summary>
	[Description("RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.")]
	public class RPC: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RPC" />.
		/// </summary>
		public RPC(): base("RPC",false,"ga:RPC")
		{
			
		}
	}
}

