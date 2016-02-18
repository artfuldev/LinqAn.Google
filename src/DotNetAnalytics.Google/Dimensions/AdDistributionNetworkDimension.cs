namespace DotNetAnalytics.Google.Dimensions
{
	public class AdDistributionNetworkDimension: Dimension<string>
	{
		/// <summary>
		/// 	The networks used to deliver your ads (Content, Search, Search partners, etc.).
		/// </summary>
		public AdDistributionNetworkDimension(): base("Ad Distribution Network","The networks used to deliver your ads (Content, Search, Search partners, etc.).",false,"ga:adDistributionNetwork")
		{
			
		}
	}
}

