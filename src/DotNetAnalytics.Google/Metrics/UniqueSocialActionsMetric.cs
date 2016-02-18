namespace DotNetAnalytics.Google.Metrics
{
	public class UniqueSocialActionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget.
		/// </summary>
		public UniqueSocialActionsMetric(): base("Unique Social Actions","The number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget.",false,"ga:uniqueSocialInteractions")
		{
			
		}
	}
}

