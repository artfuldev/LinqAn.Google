namespace DotNetAnalytics.Google.Dimensions
{
	public class QueriedProductVariationDimension: Dimension<string>
	{
		/// <summary>
		/// 	Variation of the product being queried.
		/// </summary>
		public QueriedProductVariationDimension(): base("Queried Product Variation","Variation of the product being queried.",false,"ga:queryProductVariation")
		{
			
		}
	}
}

