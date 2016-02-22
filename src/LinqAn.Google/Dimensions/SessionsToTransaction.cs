using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of sessions between users' purchases and the related campaigns that lead to the purchases.
	/// </summary>
	[Description("The number of sessions between users' purchases and the related campaigns that lead to the purchases.")]
	public class SessionsToTransaction: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionsToTransaction" />.
		/// </summary>
		public SessionsToTransaction(): base("Sessions to Transaction",true,"ga:sessionsToTransaction")
		{
			
		}
	}
}

