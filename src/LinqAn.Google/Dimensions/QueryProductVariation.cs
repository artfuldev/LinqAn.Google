using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Variation of the product being queried.
	/// </summary>
	[Description("Variation of the product being queried.")]
	public class QueryProductVariation: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QueryProductVariation" />.
		/// </summary>
		public QueryProductVariation(): base("Queried Product Variation",false,"ga:queryProductVariation")
		{
			
		}
	}
}

