namespace DotNetAnalytics.Google.Dimensions
{
	public class QueriedProductIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	ID of the product being queried.
		/// </summary>
		public QueriedProductIDDimension(): base("Queried Product ID","ID of the product being queried.",false,"ga:queryProductId")
		{
			
		}
	}
}

