using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.
	/// </summary>
	[Description("A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.")]
	public class SearchUsed: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchUsed" />.
		/// </summary>
		public SearchUsed(): base("Site Search Status",true,"ga:searchUsed")
		{
			
		}
	}
}

