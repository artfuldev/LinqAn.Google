using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Name of the product being queried.
	/// </summary>
	[Description("Name of the product being queried.")]
	public class QueryProductName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="QueryProductName" />.
		/// </summary>
		public QueryProductName(): base("Queried Product Name",false,"ga:queryProductName")
		{
			
		}
	}
}

