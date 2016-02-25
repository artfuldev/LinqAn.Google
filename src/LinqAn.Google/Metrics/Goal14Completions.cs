using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal14Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal14Completions" />.
		/// </summary>
		public Goal14Completions(): base("Goal 14 Completions",true,"ga:goal14Completions")
		{
			
		}
	}
}

