namespace DotNetAnalytics.Google.Metrics
{
	public class SocialActionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of social interactions.
		/// </summary>
		public SocialActionsMetric(): base("Social Actions","The total number of social interactions.",false,"ga:socialInteractions")
		{
			
		}
	}
}

