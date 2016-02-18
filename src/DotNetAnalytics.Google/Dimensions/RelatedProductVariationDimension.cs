namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Variation of the related product.
	/// </summary>
	public class RelatedProductVariationDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RelatedProductVariationDimension" />.
		/// </summary>
		public RelatedProductVariationDimension(): base("Related Product Variation","Variation of the related product.",false,"ga:relatedProductVariation")
		{
			
		}
	}
}

