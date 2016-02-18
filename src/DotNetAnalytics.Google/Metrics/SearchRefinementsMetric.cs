namespace DotNetAnalytics.Google.Metrics
{
	public class SearchRefinementsMetric: Metric<int>
	{
		public SearchRefinementsMetric(): base("Search Refinements","The total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: "shoes", "shoes", "pants", "pants", this metric will be one because the transition between "shoes" and "pants" is different.",true,"ga:searchRefinements")
		{
			
		}
	}
}

