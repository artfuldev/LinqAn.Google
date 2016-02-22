using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions that included an internal search
	/// </summary>
	[Description("The total number of sessions that included an internal search")]
	public class SearchSessions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchSessions" />.
		/// </summary>
		public SearchSessions(): base("Sessions with Search",true,"ga:searchSessions")
		{
			
		}
	}
}

