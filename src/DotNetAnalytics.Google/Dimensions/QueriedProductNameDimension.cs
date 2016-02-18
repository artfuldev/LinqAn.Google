namespace DotNetAnalytics.Google.Dimensions
{
	public class QueriedProductNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	Name of the product being queried.
		/// </summary>
		public QueriedProductNameDimension(): base("Queried Product Name","Name of the product being queried.",false,"ga:queryProductName")
		{
			
		}
	}
}

