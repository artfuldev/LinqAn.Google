using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Quantity of the product being queried.
	/// </summary>
	[Description("Quantity of the product being queried.")]
	public class QueryProductQuantity: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QueryProductQuantity" />.
		/// </summary>
		public QueryProductQuantity(): base("Queried Product Quantity",false,"ga:queryProductQuantity")
		{
			
		}
	}
}

