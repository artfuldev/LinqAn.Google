namespace DotNetAnalytics.Google.Dimensions
{
	public class RelatedProductNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	Name of the related product.
		/// </summary>
		public RelatedProductNameDimension(): base("Related Product Name","Name of the related product.",false,"ga:relatedProductName")
		{
			
		}
	}
}

