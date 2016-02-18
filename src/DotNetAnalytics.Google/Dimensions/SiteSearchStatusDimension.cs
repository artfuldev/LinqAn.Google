namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.
	/// </summary>
	public class SiteSearchStatusDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SiteSearchStatusDimension" />.
		/// </summary>
		public SiteSearchStatusDimension(): base("Site Search Status","A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.",true,"ga:searchUsed")
		{
			
		}
	}
}

