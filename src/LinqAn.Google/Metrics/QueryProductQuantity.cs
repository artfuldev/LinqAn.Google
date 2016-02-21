namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Quantity of the product being queried.
	/// </summary>
	public class QueryProductQuantity: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QueryProductQuantity" />.
		/// </summary>
		public QueryProductQuantity(): base("Queried Product Quantity","Quantity of the product being queried.",false,"ga:queryProductQuantity")
		{
			
		}
	}
}

