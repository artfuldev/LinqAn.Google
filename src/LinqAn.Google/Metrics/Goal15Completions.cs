using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal15Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal15Completions" />.
		/// </summary>
		public Goal15Completions(): base("Goal 15 Completions",true,"ga:goal15Completions")
		{
			
		}
	}
}

