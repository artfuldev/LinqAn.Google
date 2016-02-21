namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	ID of the related product.
	/// </summary>
	public class RelatedProductId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RelatedProductId" />.
		/// </summary>
		public RelatedProductId(): base("Related Product ID","ID of the related product.",false,"ga:relatedProductId")
		{
			
		}
	}
}

