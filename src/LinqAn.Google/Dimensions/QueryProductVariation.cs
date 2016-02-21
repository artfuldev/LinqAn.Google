namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Variation of the product being queried.
	/// </summary>
	public class QueryProductVariation: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QueryProductVariation" />.
		/// </summary>
		public QueryProductVariation(): base("Queried Product Variation","Variation of the product being queried.",false,"ga:queryProductVariation")
		{
			
		}
	}
}

