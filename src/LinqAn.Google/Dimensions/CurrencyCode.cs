namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The local currency code of the transaction based on ISO 4217 standard.
	/// </summary>
	public class CurrencyCode: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CurrencyCode" />.
		/// </summary>
		public CurrencyCode(): base("Currency Code","The local currency code of the transaction based on ISO 4217 standard.",false,"ga:currencyCode")
		{
			
		}
	}
}

