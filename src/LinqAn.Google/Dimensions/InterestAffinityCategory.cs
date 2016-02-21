namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Indicates that users are more likely to be interested in learning about the specified category.
	/// </summary>
	public class InterestAffinityCategory: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="InterestAffinityCategory" />.
		/// </summary>
		public InterestAffinityCategory(): base("Affinity Category (reach)","Indicates that users are more likely to be interested in learning about the specified category.",false,"ga:interestAffinityCategory")
		{
			
		}
	}
}

