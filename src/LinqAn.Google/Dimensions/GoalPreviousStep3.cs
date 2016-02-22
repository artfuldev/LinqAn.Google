using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The page path or screen name that matched any destination type goal, three steps prior to the goal completion location.
	/// </summary>
	[Description("The page path or screen name that matched any destination type goal, three steps prior to the goal completion location.")]
	public class GoalPreviousStep3: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalPreviousStep3" />.
		/// </summary>
		public GoalPreviousStep3(): base("Goal Previous Step - 3",false,"ga:goalPreviousStep3")
		{
			
		}
	}
}

