using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal11Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal11Completions" />.
		/// </summary>
		public Goal11Completions(): base("Goal 11 Completions",true,"ga:goal11Completions")
		{
			
		}
	}
}

