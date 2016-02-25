using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal5Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal5Completions" />.
		/// </summary>
		public Goal5Completions(): base("Goal 5 Completions",true,"ga:goal5Completions")
		{
			
		}
	}
}

