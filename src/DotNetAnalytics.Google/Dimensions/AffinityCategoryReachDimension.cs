namespace DotNetAnalytics.Google.Dimensions
{
	public class AffinityCategoryReachDimension: Dimension<string>
	{
		/// <summary>
		/// 	Indicates that users are more likely to be interested in learning about the specified category.
		/// </summary>
		public AffinityCategoryReachDimension(): base("Affinity Category (reach)","Indicates that users are more likely to be interested in learning about the specified category.",false,"ga:interestAffinityCategory")
		{
			
		}
	}
}

