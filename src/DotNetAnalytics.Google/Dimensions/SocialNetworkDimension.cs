namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialNetworkDimension: Dimension<string>
	{
		/// <summary>
		/// 	For social interactions, a value representing the social network being tracked.
		/// </summary>
		public SocialNetworkDimension(): base("Social Network","For social interactions, a value representing the social network being tracked.",false,"ga:socialInteractionNetwork")
		{
			
		}
	}
}

