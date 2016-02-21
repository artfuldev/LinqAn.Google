namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Name of the product being queried.
	/// </summary>
	public class QueryProductName: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QueryProductName" />.
		/// </summary>
		public QueryProductName(): base("Queried Product Name","Name of the product being queried.",false,"ga:queryProductName")
		{
			
		}
	}
}

