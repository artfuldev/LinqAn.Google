using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	ID of the product being queried.
	/// </summary>
	[Description("ID of the product being queried.")]
	public class QueryProductId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QueryProductId" />.
		/// </summary>
		public QueryProductId(): base("Queried Product ID",false,"ga:queryProductId")
		{
			
		}
	}
}

