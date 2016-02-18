namespace DotNetAnalytics.Google.Metrics
{
	public class ServerConnectionTimeMsMetric: Metric<int>
	{
		public ServerConnectionTimeMsMetric(): base("Server Connection Time (ms)","The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.",false,"ga:serverConnectionTime")
		{
			
		}
	}
}

