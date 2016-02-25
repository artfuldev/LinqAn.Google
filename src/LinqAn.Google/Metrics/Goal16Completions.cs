using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal16Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal16Completions" />.
		/// </summary>
		public Goal16Completions(): base("Goal 16 Completions",true,"ga:goal16Completions")
		{
			
		}
	}
}

