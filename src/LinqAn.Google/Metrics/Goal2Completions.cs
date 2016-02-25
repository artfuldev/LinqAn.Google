using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal2Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal2Completions" />.
		/// </summary>
		public Goal2Completions(): base("Goal 2 Completions",true,"ga:goal2Completions")
		{
			
		}
	}
}

