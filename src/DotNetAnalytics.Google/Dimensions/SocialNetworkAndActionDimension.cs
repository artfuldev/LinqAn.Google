namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialNetworkAndActionDimension: Dimension<string>
	{
		/// <summary>
		/// 	For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1)
		/// </summary>
		public SocialNetworkAndActionDimension(): base("Social Network and Action","For social interactions, a value representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1)",false,"ga:socialInteractionNetworkAction")
		{
			
		}
	}
}

