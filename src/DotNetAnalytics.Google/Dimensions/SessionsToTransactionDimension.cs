namespace DotNetAnalytics.Google.Dimensions
{
	public class SessionsToTransactionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The number of sessions between users' purchases and the related campaigns that lead to the purchases.
		/// </summary>
		public SessionsToTransactionDimension(): base("Sessions to Transaction","The number of sessions between users' purchases and the related campaigns that lead to the purchases.",true,"ga:sessionsToTransaction")
		{
			
		}
	}
}

