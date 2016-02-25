using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal12Completions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal12Completions" />.
		/// </summary>
		public Goal12Completions(): base("Goal 12 Completions",true,"ga:goal12Completions")
		{
			
		}
	}
}

