namespace DotNetAnalytics.Google.Metrics
{
	public class CostMetric: Metric<decimal>
	{
		/// <summary>
		/// 	Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.
		/// </summary>
		public CostMetric(): base("Cost","Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.",false,"ga:adCost")
		{
			
		}
	}
}

