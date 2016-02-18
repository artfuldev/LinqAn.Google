namespace DotNetAnalytics.Google.Dimensions
{
	public class DaysToTransactionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The number of days between users' purchases and the related campaigns that lead to the purchases.
		/// </summary>
		public DaysToTransactionDimension(): base("Days to Transaction","The number of days between users' purchases and the related campaigns that lead to the purchases.",true,"ga:daysToTransaction")
		{
			
		}
	}
}

