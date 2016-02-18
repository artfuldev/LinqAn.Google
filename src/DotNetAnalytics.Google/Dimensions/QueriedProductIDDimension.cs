namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	ID of the product being queried.
	/// </summary>
	public class QueriedProductIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QueriedProductIDDimension" />.
		/// </summary>
		public QueriedProductIDDimension(): base("Queried Product ID","ID of the product being queried.",false,"ga:queryProductId")
		{
			
		}
	}
}

