using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal1Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal1Completions" />.
		/// </summary>
		public Goal1Completions(): base("Goal 1 Completions",true,"ga:goal1Completions")
		{
			
		}
	}
}

