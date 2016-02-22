using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API Campaign.id.
	/// </summary>
	[Description("A string. Corresponds to AdWords API Campaign.id.")]
	public class AdwordsCampaignId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdwordsCampaignId" />.
		/// </summary>
		public AdwordsCampaignId(): base("AdWords Campaign ID",false,"ga:adwordsCampaignID")
		{
			
		}
	}
}

