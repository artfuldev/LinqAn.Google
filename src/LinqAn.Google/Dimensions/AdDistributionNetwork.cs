using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The networks used to deliver your ads (Content, Search, Search partners, etc.).
	/// </summary>
	[Description("The networks used to deliver your ads (Content, Search, Search partners, etc.).")]
	public class AdDistributionNetwork: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdDistributionNetwork" />.
		/// </summary>
		public AdDistributionNetwork(): base("Ad Distribution Network",false,"ga:adDistributionNetwork")
		{
			
		}
	}
}

