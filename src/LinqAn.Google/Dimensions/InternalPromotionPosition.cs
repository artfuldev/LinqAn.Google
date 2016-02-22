using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The position of the promotion on the web page or application screen (Enhanced Ecommerce).
	/// </summary>
	[Description("The position of the promotion on the web page or application screen (Enhanced Ecommerce).")]
	public class InternalPromotionPosition: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionPosition" />.
		/// </summary>
		public InternalPromotionPosition(): base("Internal Promotion Position",true,"ga:internalPromotionPosition")
		{
			
		}
	}
}

