using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal3Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal3Completions" />.
		/// </summary>
		public Goal3Completions(): base("Goal 3 Completions",true,"ga:goal3Completions")
		{
			
		}
	}
}

