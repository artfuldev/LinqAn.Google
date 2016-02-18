namespace DotNetAnalytics.Google.Dimensions
{
	public class SocialActionDimension: Dimension<string>
	{
		/// <summary>
		/// 	For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)
		/// </summary>
		public SocialActionDimension(): base("Social Action","For social interactions, a value representing the social action being tracked (e.g. +1, bookmark)",false,"ga:socialInteractionAction")
		{
			
		}
	}
}

