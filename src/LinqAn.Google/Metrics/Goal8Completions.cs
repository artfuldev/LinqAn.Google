using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal8Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal8Completions" />.
		/// </summary>
		public Goal8Completions(): base("Goal 8 Completions",true,"ga:goal8Completions")
		{
			
		}
	}
}

