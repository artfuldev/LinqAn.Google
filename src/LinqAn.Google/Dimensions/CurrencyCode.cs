using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The local currency code of the transaction based on ISO 4217 standard.
	/// </summary>
	[Description("The local currency code of the transaction based on ISO 4217 standard.")]
	public class CurrencyCode: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CurrencyCode" />.
		/// </summary>
		public CurrencyCode(): base("Currency Code",false,"ga:currencyCode")
		{
			
		}
	}
}

