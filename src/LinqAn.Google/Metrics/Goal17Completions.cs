using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal17Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal17Completions" />.
		/// </summary>
		public Goal17Completions(): base("Goal 17 Completions",true,"ga:goal17Completions")
		{
			
		}
	}
}

