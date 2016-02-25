using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal13Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal13Completions" />.
		/// </summary>
		public Goal13Completions(): base("Goal 13 Completions",true,"ga:goal13Completions")
		{
			
		}
	}
}

