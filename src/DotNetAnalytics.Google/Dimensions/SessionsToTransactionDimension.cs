namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The number of sessions between users' purchases and the related campaigns that lead to the purchases.
	/// </summary>
	public class SessionsToTransactionDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SessionsToTransactionDimension" />.
		/// </summary>
		public SessionsToTransactionDimension(): base("Sessions to Transaction","The number of sessions between users' purchases and the related campaigns that lead to the purchases.",true,"ga:sessionsToTransaction")
		{
			
		}
	}
}

