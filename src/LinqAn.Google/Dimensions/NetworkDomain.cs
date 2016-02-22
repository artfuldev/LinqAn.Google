using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.
	/// </summary>
	[Description("The domain name of the ISPs used by users. This is derived from the domain name registered to the IP address.")]
	public class NetworkDomain: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NetworkDomain" />.
		/// </summary>
		public NetworkDomain(): base("Network Domain",true,"ga:networkDomain")
		{
			
		}
	}
}

