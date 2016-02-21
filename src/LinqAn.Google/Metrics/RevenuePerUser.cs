namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.
	/// </summary>
	public class RevenuePerUser: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RevenuePerUser" />.
		/// </summary>
		public RevenuePerUser(): base("Revenue per User","The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.",false,"ga:revenuePerUser")
		{
			
		}
	}
}

