namespace DotNetAnalytics.Google.Dimensions
{
	public class FullReferrerDimension: Dimension<string>
	{
		/// <summary>
		/// 	The full referring URL including the hostname and path.
		/// </summary>
		public FullReferrerDimension(): base("Full Referrer","The full referring URL including the hostname and path.",false,"ga:fullReferrer")
		{
			
		}
	}
}

