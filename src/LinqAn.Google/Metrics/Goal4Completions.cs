using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal4Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal4Completions" />.
		/// </summary>
		public Goal4Completions(): base("Goal 4 Completions",true,"ga:goal4Completions")
		{
			
		}
	}
}

