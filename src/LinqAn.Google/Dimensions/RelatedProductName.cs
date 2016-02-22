using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Name of the related product.
	/// </summary>
	[Description("Name of the related product.")]
	public class RelatedProductName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RelatedProductName" />.
		/// </summary>
		public RelatedProductName(): base("Related Product Name",false,"ga:relatedProductName")
		{
			
		}
	}
}

