using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The search queries that triggered impressions of your AdWords ads.
	/// </summary>
	[Description("The search queries that triggered impressions of your AdWords ads.")]
	public class AdMatchedQuery: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdMatchedQuery" />.
		/// </summary>
		public AdMatchedQuery(): base("Matched Search Query",false,"ga:adMatchedQuery")
		{
			
		}
	}
}

