namespace DotNetAnalytics.Google.Dimensions
{
	public class RelatedProductIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	ID of the related product.
		/// </summary>
		public RelatedProductIDDimension(): base("Related Product ID","ID of the related product.",false,"ga:relatedProductId")
		{
			
		}
	}
}

