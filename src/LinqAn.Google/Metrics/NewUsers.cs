namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of users whose session was marked as a first-time session.
	/// </summary>
	public class NewUsers: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="NewUsers" />.
		/// </summary>
		public NewUsers(): base("New Users","The number of users whose session was marked as a first-time session.",true,"ga:newUsers")
		{
			
		}
	}
}

