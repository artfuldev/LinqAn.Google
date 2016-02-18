namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Name of the related product.
	/// </summary>
	public class RelatedProductNameDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RelatedProductNameDimension" />.
		/// </summary>
		public RelatedProductNameDimension(): base("Related Product Name","Name of the related product.",false,"ga:relatedProductName")
		{
			
		}
	}
}

