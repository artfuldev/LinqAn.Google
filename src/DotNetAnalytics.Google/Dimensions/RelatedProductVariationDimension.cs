namespace DotNetAnalytics.Google.Dimensions
{
	public class RelatedProductVariationDimension: Dimension<string>
	{
		/// <summary>
		/// 	Variation of the related product.
		/// </summary>
		public RelatedProductVariationDimension(): base("Related Product Variation","Variation of the related product.",false,"ga:relatedProductVariation")
		{
			
		}
	}
}

