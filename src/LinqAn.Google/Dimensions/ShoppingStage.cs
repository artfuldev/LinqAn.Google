using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART, CHECKOUT, etc. (Enhanced Ecommerce).
	/// </summary>
	[Description("Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART, CHECKOUT, etc. (Enhanced Ecommerce).")]
	public class ShoppingStage: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ShoppingStage" />.
		/// </summary>
		public ShoppingStage(): base("Shopping Stage",true,"ga:shoppingStage")
		{
			
		}
	}
}

