using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of users for the requested time period.
	/// </summary>
	[Description("The total number of users for the requested time period.")]
	public class Users: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Users" />.
		/// </summary>
		public Users(): base("Users",false,"ga:users")
		{
			
		}
	}
}

