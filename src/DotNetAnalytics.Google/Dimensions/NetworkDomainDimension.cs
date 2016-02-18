namespace DotNetAnalytics.Google.Dimensions
{
	public class NetworkDomainDimension: Dimension<string>
	{
		/// <summary>
		/// 	The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.
		/// </summary>
		public NetworkDomainDimension(): base("Network Domain","The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.",true,"ga:networkDomain")
		{
			
		}
	}
}

