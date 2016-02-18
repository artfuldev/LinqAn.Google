namespace DotNetAnalytics.Google.Dimensions
{
	public class CheckoutOptionsDimension: Dimension<string>
	{
		/// <summary>
		/// 	User options specified during the checkout process, e.g., FedEx, DHL, UPS for delivery options or Visa, MasterCard, AmEx for payment options. This dimension should be used along with ga:shoppingStage (Enhanced Ecommerce).
		/// </summary>
		public CheckoutOptionsDimension(): base("Checkout Options","User options specified during the checkout process, e.g., FedEx, DHL, UPS for delivery options or Visa, MasterCard, AmEx for payment options. This dimension should be used along with ga:shoppingStage (Enhanced Ecommerce).",true,"ga:checkoutOptions")
		{
			
		}
	}
}

