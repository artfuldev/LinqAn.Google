using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of users whose session was marked as a first-time session.
	/// </summary>
	[Description("The number of users whose session was marked as a first-time session.")]
	public class NewUsers: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NewUsers" />.
		/// </summary>
		public NewUsers(): base("New Users",true,"ga:newUsers")
		{
			
		}
	}
}

