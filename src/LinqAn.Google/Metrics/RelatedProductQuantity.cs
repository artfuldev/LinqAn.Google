using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Quantity of the related product.
	/// </summary>
	[Description("Quantity of the related product.")]
	public class RelatedProductQuantity: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RelatedProductQuantity" />.
		/// </summary>
		public RelatedProductQuantity(): base("Related Product Quantity",false,"ga:relatedProductQuantity")
		{
			
		}
	}
}

