using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Variation of the related product.
	/// </summary>
	[Description("Variation of the related product.")]
	public class RelatedProductVariation: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RelatedProductVariation" />.
		/// </summary>
		public RelatedProductVariation(): base("Related Product Variation",false,"ga:relatedProductVariation")
		{
			
		}
	}
}

