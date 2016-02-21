namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of sessions between users' purchases and the related campaigns that lead to the purchases.
	/// </summary>
	public class SessionsToTransaction: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionsToTransaction" />.
		/// </summary>
		public SessionsToTransaction(): base("Sessions to Transaction","The number of sessions between users' purchases and the related campaigns that lead to the purchases.",true,"ga:sessionsToTransaction")
		{
			
		}
	}
}

