namespace DotNetAnalytics.Google.Dimensions
{
	public class CurrencyCodeDimension: Dimension<string>
	{
		/// <summary>
		/// 	The local currency code of the transaction based on ISO 4217 standard.
		/// </summary>
		public CurrencyCodeDimension(): base("Currency Code","The local currency code of the transaction based on ISO 4217 standard.",false,"ga:currencyCode")
		{
			
		}
	}
}

