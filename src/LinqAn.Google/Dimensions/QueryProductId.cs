namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	ID of the product being queried.
	/// </summary>
	public class QueryProductId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QueryProductId" />.
		/// </summary>
		public QueryProductId(): base("Queried Product ID","ID of the product being queried.",false,"ga:queryProductId")
		{
			
		}
	}
}

