using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	ID of the related product.
	/// </summary>
	[Description("ID of the related product.")]
	public class RelatedProductId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RelatedProductId" />.
		/// </summary>
		public RelatedProductId(): base("Related Product ID",false,"ga:relatedProductId")
		{
			
		}
	}
}

