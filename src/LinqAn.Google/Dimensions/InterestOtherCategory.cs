using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase.
	/// </summary>
	[Description("Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase.")]
	public class InterestOtherCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InterestOtherCategory" />.
		/// </summary>
		public InterestOtherCategory(): base("Other Category",false,"ga:interestOtherCategory")
		{
			
		}
	}
}

