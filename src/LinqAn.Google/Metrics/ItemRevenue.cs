namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total revenue from purchased product items.
	/// </summary>
	public class ItemRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ItemRevenue" />.
		/// </summary>
		public ItemRevenue(): base("Product Revenue","The total revenue from purchased product items.",true,"ga:itemRevenue")
		{
			
		}
	}
}

