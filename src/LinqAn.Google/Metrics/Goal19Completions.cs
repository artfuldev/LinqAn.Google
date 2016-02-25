using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal19Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal19Completions" />.
		/// </summary>
		public Goal19Completions(): base("Goal 19 Completions",true,"ga:goal19Completions")
		{
			
		}
	}
}

