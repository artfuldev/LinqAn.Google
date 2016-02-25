using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal18Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal18Completions" />.
		/// </summary>
		public Goal18Completions(): base("Goal 18 Completions",true,"ga:goal18Completions")
		{
			
		}
	}
}

