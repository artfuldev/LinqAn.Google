namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.
	/// </summary>
	public class NetworkDomain: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NetworkDomain" />.
		/// </summary>
		public NetworkDomain(): base("Network Domain","The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.",true,"ga:networkDomain")
		{
			
		}
	}
}

