using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal7Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal7Completions" />.
		/// </summary>
		public Goal7Completions(): base("Goal 7 Completions",true,"ga:goal7Completions")
		{
			
		}
	}
}

