using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal9Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal9Completions" />.
		/// </summary>
		public Goal9Completions(): base("Goal 9 Completions",true,"ga:goal9Completions")
		{
			
		}
	}
}

