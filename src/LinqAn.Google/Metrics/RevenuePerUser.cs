using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.
	/// </summary>
	[Description("The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.")]
	public class RevenuePerUser: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RevenuePerUser" />.
		/// </summary>
		public RevenuePerUser(): base("Revenue per User",false,"ga:revenuePerUser")
		{
			
		}
	}
}

