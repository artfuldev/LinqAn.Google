using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the promotion (Enhanced Ecommerce).
	/// </summary>
	[Description("The name of the promotion (Enhanced Ecommerce).")]
	public class InternalPromotionName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionName" />.
		/// </summary>
		public InternalPromotionName(): base("Internal Promotion Name",true,"ga:internalPromotionName")
		{
			
		}
	}
}

