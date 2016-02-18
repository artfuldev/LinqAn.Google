namespace DotNetAnalytics.Google.Dimensions
{
	public class GoalPreviousStep2Dimension: Dimension<string>
	{
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, two steps prior to the goal completion location.
		/// </summary>
		public GoalPreviousStep2Dimension(): base("Goal Previous Step - 2","The page path or screen name that matched any destination type goal, two steps prior to the goal completion location.",false,"ga:goalPreviousStep2")
		{
			
		}
	}
}

