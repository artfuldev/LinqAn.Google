using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal20Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal20Completions" />.
		/// </summary>
		public Goal20Completions(): base("Goal 20 Completions",true,"ga:goal20Completions")
		{
			
		}
	}
}

