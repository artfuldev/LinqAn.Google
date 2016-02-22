namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.
	/// </summary>
	public class SearchUsed: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchUsed" />.
		/// </summary>
		public SearchUsed(): base("Site Search Status","A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.",true,"ga:searchUsed")
		{
			
		}
	}
}

