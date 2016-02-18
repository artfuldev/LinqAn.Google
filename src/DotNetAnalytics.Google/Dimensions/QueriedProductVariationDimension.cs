namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Variation of the product being queried.
	/// </summary>
	public class QueriedProductVariationDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QueriedProductVariationDimension" />.
		/// </summary>
		public QueriedProductVariationDimension(): base("Queried Product Variation","Variation of the product being queried.",false,"ga:queryProductVariation")
		{
			
		}
	}
}

