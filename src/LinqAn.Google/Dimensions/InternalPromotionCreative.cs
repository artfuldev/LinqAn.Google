using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The creative content designed for a promotion (Enhanced Ecommerce).
	/// </summary>
	[Description("The creative content designed for a promotion (Enhanced Ecommerce).")]
	public class InternalPromotionCreative: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionCreative" />.
		/// </summary>
		public InternalPromotionCreative(): base("Internal Promotion Creative",true,"ga:internalPromotionCreative")
		{
			
		}
	}
}

