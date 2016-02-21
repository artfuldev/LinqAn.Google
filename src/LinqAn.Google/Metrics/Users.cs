namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of users for the requested time period.
	/// </summary>
	public class Users: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Users" />.
		/// </summary>
		public Users(): base("Users","The total number of users for the requested time period.",false,"ga:users")
		{
			
		}
	}
}

