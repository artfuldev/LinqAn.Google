namespace DotNetAnalytics.Google.Dimensions
{
	public class GoalPreviousStep3Dimension: Dimension<string>
	{
		/// <summary>
		/// 	The page path or screen name that matched any destination type goal, three steps prior to the goal completion location.
		/// </summary>
		public GoalPreviousStep3Dimension(): base("Goal Previous Step - 3","The page path or screen name that matched any destination type goal, three steps prior to the goal completion location.",false,"ga:goalPreviousStep3")
		{
			
		}
	}
}

