using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for all goals defined for your profile.
	/// </summary>
	[Description("The total number of completions for all goals defined for your profile.")]
	public class GoalCompletionsAll: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalCompletionsAll" />.
		/// </summary>
		public GoalCompletionsAll(): base("Goal Completions",true,"ga:goalCompletionsAll")
		{
			
		}
	}
}

