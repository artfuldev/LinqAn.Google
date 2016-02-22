using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The page path or screen name that matched any destination type goal completion.
	/// </summary>
	[Description("The page path or screen name that matched any destination type goal completion.")]
	public class GoalCompletionLocation: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalCompletionLocation" />.
		/// </summary>
		public GoalCompletionLocation(): base("Goal Completion Location",false,"ga:goalCompletionLocation")
		{
			
		}
	}
}

