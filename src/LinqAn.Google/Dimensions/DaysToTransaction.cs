namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of days between users' purchases and the related campaigns that lead to the purchases.
	/// </summary>
	public class DaysToTransaction: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DaysToTransaction" />.
		/// </summary>
		public DaysToTransaction(): base("Days to Transaction","The number of days between users' purchases and the related campaigns that lead to the purchases.",true,"ga:daysToTransaction")
		{
			
		}
	}
}

