namespace DotNetAnalytics.Google.Metrics
{
	public class SocialActionsMetric: Metric<int>
	{
		public SocialActionsMetric(): base("Social Actions","The total number of social interactions.",false,"ga:socialInteractions")
		{
			
		}
	}
}

