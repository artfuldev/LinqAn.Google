using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The ID of the promotion (Enhanced Ecommerce).
	/// </summary>
	[Description("The ID of the promotion (Enhanced Ecommerce).")]
	public class InternalPromotionId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionId" />.
		/// </summary>
		public InternalPromotionId(): base("Internal Promotion ID",true,"ga:internalPromotionId")
		{
			
		}
	}
}

