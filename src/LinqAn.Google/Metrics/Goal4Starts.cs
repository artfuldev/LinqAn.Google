using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal4Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal4Starts" />.
		/// </summary>
		public Goal4Starts(): base("Goal 4 Starts",true,"ga:goal4Starts")
		{
			
		}
	}
}

