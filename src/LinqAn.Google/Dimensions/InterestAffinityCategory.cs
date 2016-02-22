using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Indicates that users are more likely to be interested in learning about the specified category.
	/// </summary>
	[Description("Indicates that users are more likely to be interested in learning about the specified category.")]
	public class InterestAffinityCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InterestAffinityCategory" />.
		/// </summary>
		public InterestAffinityCategory(): base("Affinity Category (reach)",false,"ga:interestAffinityCategory")
		{
			
		}
	}
}

