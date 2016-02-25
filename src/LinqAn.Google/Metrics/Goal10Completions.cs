using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal10Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal10Completions" />.
		/// </summary>
		public Goal10Completions(): base("Goal 10 Completions",true,"ga:goal10Completions")
		{
			
		}
	}
}

