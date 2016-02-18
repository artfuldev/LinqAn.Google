namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Indicates that users are more likely to be interested in learning about the specified category.
	/// </summary>
	public class AffinityCategoryReachDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AffinityCategoryReachDimension" />.
		/// </summary>
		public AffinityCategoryReachDimension(): base("Affinity Category (reach)","Indicates that users are more likely to be interested in learning about the specified category.",false,"ga:interestAffinityCategory")
		{
			
		}
	}
}

