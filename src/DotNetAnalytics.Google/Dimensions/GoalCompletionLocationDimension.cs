namespace DotNetAnalytics.Google.Dimensions
{
	public class GoalCompletionLocationDimension: Dimension<string>
	{
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal completion.
		/// </summary>
		public GoalCompletionLocationDimension(): base("Goal Completion Location","The page path or screen name that matched any destination type goal completion.",false,"ga:goalCompletionLocation")
		{
			
		}
	}
}

